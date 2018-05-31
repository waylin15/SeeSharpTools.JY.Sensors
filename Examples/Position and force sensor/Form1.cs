using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JYUSB62401;
using SeeSharpTools.JY.ArrayUtility;
using JY.UnitConversion;
using SeeSharpTools.JY.Sensors;

namespace Position_and_force_sensor
{
    public partial class Form1 : Form
    {
        #region Private Fields
        /// <summary>
        /// AI任务
        /// </summary>
        private JYUSB62401AITask aitask;

        /// <summary>
        /// 存放AI采集到的数据，容量为100ms样点数
        /// </summary>
        private double[,] readValue;
        private double[,] displayValue;

        private LoadCell _loadCell;
        private DisplacementSensor _displacementsensor;
        private Thermistor _thermistor;
        /// <summary>
        /// 板卡号
        /// </summary>
        private int boardNum;
        #endregion
        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        #region Event Handler
        /// <summary>
        /// 设置comboBox的默认索引
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_boardNum.SelectedIndex = 0;
            SampleRateCombo.SelectedIndex = 7;
            stripChart_position.YAutoEnable = false;
            stripChart_position.AxisYMax = 10;
            stripChart_position.AxisYMin = 0;

            stripChart_weight.YAutoEnable = true;
            this._loadCell = new LoadCell(1.5,1000,5);
            this._displacementsensor = new DisplacementSensor(5000, 10,0);
            this._thermistor = new Thermistor(100000, 3950);
            //stripChart_weight.AxisYMax = 1000;
            //stripChart_weight.AxisYMin = 0;
        }

        /// <summary>
        /// 根据选择的板卡号创建任务
        ///// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_boardNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                boardNum = comboBox_boardNum.SelectedIndex;
                aitask = new JYUSB62401AITask(boardNum);
            }
            catch (JYDriverException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        /// <summary>
        /// 启动采集 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, EventArgs e)
        {
            
           if (null == aitask)
            {
                return;
            }
            //添加通道
            try
            {
                int channelCount = 3;
                aitask.AddChannel(0, ChannelType.Voltage);
                aitask.AddChannel(1, ChannelType.Resistor);
                aitask.AddChannel(2, ChannelType.Resistor);
                //基本参数配置
                aitask.Mode = AIMode.Continuous;
                aitask.SampleRate = Convert.ToDouble(SampleRateCombo.SelectedItem.ToString());
                aitask.Start();

                readValue = new double[(int)aitask.SampleRate / 3, channelCount];
                displayValue = new double[channelCount, (int)aitask.SampleRate / 3];
                toolStripStatusLabel.Text = "开始采集";
           

                timer1.Enabled = true;
                groupBox1.Enabled = false;
                Start.Enabled = false;
                button1.Enabled = false;
            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = "开始采集失败。";
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 停止采集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stop_Click(object sender, EventArgs e)
        {
            aitask?.Stop();
            aitask?.Channels.Clear();//把上次启动添加的通道清掉
            timer1.Enabled = false;//禁用定时器，重新启动参数配置按钮
            groupBox1.Enabled = true;
           
            Start.Enabled = true;
            toolStripStatusLabel.Text = "停止采集任务";
            button1.Enabled = true;
        }
        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            aitask?.Stop();
        }
        /// <summary>
        /// 定时器，每秒钟刷新一次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        { 
            try
            {
                //如果本地缓冲区数据足够则读取数据并显示，如果不够，返回
                if (aitask.AvailableSamples < readValue.Length)
                {
                    return;
                }
                timer1.Enabled = false;
               
                aitask.ReadData(ref readValue, -1);
                toolStripStatusLabel.Text = "正在读取数据中...";
                ArrayManipulation.Transpose(readValue, ref displayValue);
                int size = displayValue.Length / 3;
                double[] buf1 = new double[size];
                double[] buf2 = new double[size];
                double[] buf3 = new double[size];
                Buffer.BlockCopy(displayValue, 0, buf1, 0, size * sizeof(double));
                Buffer.BlockCopy(displayValue, size * sizeof(double), buf2, 0, size * sizeof(double));
                Buffer.BlockCopy(displayValue, size * sizeof(double), buf3, 0, size * sizeof(double));
                stripChart_position.Plot(_displacementsensor.Convert(buf2));
                //stripChart_position.Plot(Conversion.resistance(buf2, RMax, 10, "cm"));
                //stripChart_weight.Plot(Conversion.Weight(buf1, 12, 250, 2000, 350, 500, "kg"));

                stripChart_weight.Plot(_loadCell.Convert(buf1));
                stripChart1.Plot(_thermistor.Convert(buf3));

                timer1.Enabled = true;
            }
            catch (JYDriverException ex)
            {
                if (ex.ErrorCode == -2|| ex.ErrorCode == -4|| ex.ErrorCode == -304)
                {
                    led1.Value = false;
                    button1.Enabled = true;
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                aitask?.Stop();
            
                Start.Enabled = true;
                toolStripStatusLabel.Text = "读取数据失败";
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                aitask = new JYUSB62401AITask(int.Parse(comboBox_boardNum.Text));
                led1.Value = true;
            }
            catch (Exception ex)
            {
                led1.Value = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
#endregion