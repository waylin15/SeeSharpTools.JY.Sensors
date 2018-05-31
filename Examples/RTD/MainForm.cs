using SeeSharpTools.JY.Sensors;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SeeSharpTools.Examples
{
    public partial class MainForm : Form
    {
        private Random rand = new Random();
        private double value;
        private double[] values;
        private Stopwatch sp = new Stopwatch();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                item.Visible = false;
            }

            switch (comboBox1.SelectedItem.ToString())
            {
                case "位移传感器":
                    groupBox_dispSensor.Visible = true;
                    break;

                case "荷重传感器":
                    groupBox_loadcell.Visible = true;
                    break;

                case "热电阻RTD_PT100":
                    break;

                case "热敏电阻Thermistor":
                    groupBox_thermistor.Visible = true;
                    break;

                case "热电偶Thermocouple":
                    groupBox_thermocouple.Visible = true;
                    break;

                default:
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            values = new double[10000];
        }

        private void easyButton1_Click(object sender, EventArgs e)
        {
            value = (double)numericUpDown_value.Value;
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = value;
            }
            double[] res;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "位移传感器":
                    numericUpDown_result.Value = (decimal)DisplacementSensor.Convert(value, (double)numericUpDown_maxDisp.Value, (double)numericUpDown_maxR.Value, (double)numericUpDown_minR.Value);
                    res = DisplacementSensor.Convert(values, (double)numericUpDown_maxDisp.Value, (double)numericUpDown_maxR.Value, (double)numericUpDown_minR.Value);
                    easyChartX1.Plot(res);
                    break;

                case "荷重传感器":
                    numericUpDown_result.Value = (decimal)LoadCell.Convert(value, (double)numericUpDown_sensitivity.Value, (double)numericUpDown_maxLoad.Value, (double)numericUpDown_excitationVolt.Value);
                    res = LoadCell.Convert(values, (double)numericUpDown_sensitivity.Value, (double)numericUpDown_maxLoad.Value, (double)numericUpDown_excitationVolt.Value);
                    easyChartX1.Plot(res);
                    break;

                case "热电阻RTD_PT100":
                    numericUpDown_result.Value = (decimal)RTD.Convert(value);
                    res = RTD.Convert(values);
                    easyChartX1.Plot(res);
                    break;

                case "热敏电阻Thermistor":
                    numericUpDown_result.Value = (decimal)Thermistor.Convert(value, (double)numericUpDown_resistorRT.Value, (double)numericUpDown_beta.Value);
                    res = Thermistor.Convert(values, (double)numericUpDown_resistorRT.Value, (double)numericUpDown_beta.Value);
                    easyChartX1.Plot(res);
                    break;

                case "热电偶Thermocouple":
                    numericUpDown_result.Value = (decimal)Thermocouple.Convert((ThermocoupleType)Enum.Parse(typeof(ThermocoupleType), comboBox2.Text), value, checkBox_cjcEnable.Checked,(double)numericUpDown_cjcTemperature.Value);
                    res = Thermocouple.Convert((ThermocoupleType)Enum.Parse(typeof(ThermocoupleType), comboBox2.Text), values, checkBox_cjcEnable.Checked,(double)numericUpDown_cjcTemperature.Value);
                    easyChartX1.Plot(res);
                    break;

                default:
                    break;
            }
        }
    }
}