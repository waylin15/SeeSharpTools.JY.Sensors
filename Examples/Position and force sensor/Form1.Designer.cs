namespace Position_and_force_sensor
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SampleRateCombo = new System.Windows.Forms.ComboBox();
            this.comboBox_boardNum = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.led1 = new SeeSharpTools.JY.GUI.LED();
            this.button1 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.stripChart_weight = new SeeSharpTools.JY.GUI.StripChart();
            this.stripChart_position = new SeeSharpTools.JY.GUI.StripChart();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stripChart1 = new SeeSharpTools.JY.GUI.StripChart();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(680, 370);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 45);
            this.Start.TabIndex = 4;
            this.Start.Text = "开始测量";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Stop.ForeColor = System.Drawing.Color.White;
            this.Stop.Location = new System.Drawing.Point(786, 370);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 45);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "停止测量";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.SampleRateCombo);
            this.groupBox1.Controls.Add(this.comboBox_boardNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(650, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 107);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本参数配置";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SampleRateCombo
            // 
            this.SampleRateCombo.FormattingEnabled = true;
            this.SampleRateCombo.Items.AddRange(new object[] {
            "20",
            "40",
            "80",
            "160",
            "320",
            "500",
            "1000",
            "2000"});
            this.SampleRateCombo.Location = new System.Drawing.Point(88, 68);
            this.SampleRateCombo.Name = "SampleRateCombo";
            this.SampleRateCombo.Size = new System.Drawing.Size(121, 20);
            this.SampleRateCombo.TabIndex = 5;
            // 
            // comboBox_boardNum
            // 
            this.comboBox_boardNum.FormattingEnabled = true;
            this.comboBox_boardNum.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox_boardNum.Location = new System.Drawing.Point(88, 27);
            this.comboBox_boardNum.Name = "comboBox_boardNum";
            this.comboBox_boardNum.Size = new System.Drawing.Size(121, 20);
            this.comboBox_boardNum.TabIndex = 3;
            this.comboBox_boardNum.SelectedIndexChanged += new System.EventHandler(this.comboBox_boardNum_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "采样率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "板卡号";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(965, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(124, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // led1
            // 
            this.led1.BackColor = System.Drawing.Color.Transparent;
            this.led1.BlinkColor = System.Drawing.Color.Lime;
            this.led1.BlinkInterval = 1000;
            this.led1.BlinkOn = false;
            this.led1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.led1.Interacton = SeeSharpTools.JY.GUI.LED.InteractionStyle.Indicator;
            this.led1.Location = new System.Drawing.Point(668, 131);
            this.led1.Name = "led1";
            this.led1.OffColor = System.Drawing.Color.Red;
            this.led1.OnColor = System.Drawing.Color.Lime;
            this.led1.Size = new System.Drawing.Size(33, 33);
            this.led1.Style = SeeSharpTools.JY.GUI.LED.LedStyle.Circular;
            this.led1.TabIndex = 9;
            this.led1.Value = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(750, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "连接板卡";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(965, 80);
            this.splitter1.TabIndex = 67;
            this.splitter1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(39)))), ((int)(((byte)(34)))));
            this.label4.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(226, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(440, 33);
            this.label4.TabIndex = 69;
            this.label4.Text = "Position and force sensor";
            // 
            // stripChart_weight
            // 
            this.stripChart_weight.AxisYMax = 3.5D;
            this.stripChart_weight.AxisYMin = 0D;
            this.stripChart_weight.BackColor = System.Drawing.Color.Transparent;
            this.stripChart_weight.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.stripChart_weight.ChartBackColor = System.Drawing.Color.Transparent;
            this.stripChart_weight.Displaydirection = SeeSharpTools.JY.GUI.StripChart.DisplayDirection.RightToLeft;
            this.stripChart_weight.DisPlayPoints = 10000;
            this.stripChart_weight.LegendVisible = false;
            this.stripChart_weight.LineNum = 1;
            this.stripChart_weight.LineWidth = new int[] {
        1};
            this.stripChart_weight.Location = new System.Drawing.Point(14, 91);
            this.stripChart_weight.MajorGridEnabled = true;
            this.stripChart_weight.MinorGridEnabled = false;
            this.stripChart_weight.Name = "stripChart_weight";
            this.stripChart_weight.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            this.stripChart_weight.SeriesNames = new string[] {
        "Weight",
        "Position"};
            this.stripChart_weight.Size = new System.Drawing.Size(605, 173);
            this.stripChart_weight.TabIndex = 70;
            this.stripChart_weight.XAxisStartIndex = 0;
            this.stripChart_weight.XAxisTypes = SeeSharpTools.JY.GUI.StripChart.XAxisDataType.Index;
            this.stripChart_weight.YAutoEnable = false;
            this.stripChart_weight.YAxisLogarithmic = false;
            // 
            // stripChart_position
            // 
            this.stripChart_position.AxisYMax = 3.5D;
            this.stripChart_position.AxisYMin = 0D;
            this.stripChart_position.BackColor = System.Drawing.Color.Transparent;
            this.stripChart_position.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.stripChart_position.ChartBackColor = System.Drawing.Color.Transparent;
            this.stripChart_position.Displaydirection = SeeSharpTools.JY.GUI.StripChart.DisplayDirection.RightToLeft;
            this.stripChart_position.DisPlayPoints = 1000;
            this.stripChart_position.LegendVisible = false;
            this.stripChart_position.LineNum = 1;
            this.stripChart_position.LineWidth = new int[] {
        1};
            this.stripChart_position.Location = new System.Drawing.Point(8, 279);
            this.stripChart_position.MajorGridEnabled = true;
            this.stripChart_position.MinorGridEnabled = false;
            this.stripChart_position.Name = "stripChart_position";
            this.stripChart_position.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            this.stripChart_position.SeriesNames = new string[] {
        "Weight",
        "Position"};
            this.stripChart_position.Size = new System.Drawing.Size(605, 173);
            this.stripChart_position.TabIndex = 71;
            this.stripChart_position.XAxisStartIndex = 0;
            this.stripChart_position.XAxisTypes = SeeSharpTools.JY.GUI.StripChart.XAxisDataType.Index;
            this.stripChart_position.YAutoEnable = false;
            this.stripChart_position.YAxisLogarithmic = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 72;
            this.label6.Text = "称重示数(N)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 73;
            this.label7.Text = "位移示数（cm）";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(639, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 74;
            this.label8.Text = "板卡连接检测";
            // 
            // stripChart1
            // 
            this.stripChart1.AxisYMax = 3.5D;
            this.stripChart1.AxisYMin = 0D;
            this.stripChart1.BackColor = System.Drawing.Color.Transparent;
            this.stripChart1.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.stripChart1.ChartBackColor = System.Drawing.Color.Transparent;
            this.stripChart1.Displaydirection = SeeSharpTools.JY.GUI.StripChart.DisplayDirection.RightToLeft;
            this.stripChart1.DisPlayPoints = 1000;
            this.stripChart1.LegendVisible = false;
            this.stripChart1.LineNum = 1;
            this.stripChart1.LineWidth = new int[] {
        1};
            this.stripChart1.Location = new System.Drawing.Point(14, 476);
            this.stripChart1.MajorGridEnabled = true;
            this.stripChart1.MinorGridEnabled = false;
            this.stripChart1.Name = "stripChart1";
            this.stripChart1.Palette = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            this.stripChart1.SeriesNames = new string[] {
        "Weight",
        "Position"};
            this.stripChart1.Size = new System.Drawing.Size(605, 173);
            this.stripChart1.TabIndex = 75;
            this.stripChart1.XAxisStartIndex = 0;
            this.stripChart1.XAxisTypes = SeeSharpTools.JY.GUI.StripChart.XAxisDataType.Index;
            this.stripChart1.YAutoEnable = false;
            this.stripChart1.YAxisLogarithmic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(965, 661);
            this.Controls.Add(this.stripChart1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stripChart_weight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.led1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.stripChart_position);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(981, 700);
            this.MinimumSize = new System.Drawing.Size(981, 528);
            this.Name = "Form1";
            this.Text = "Position and force sensor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SampleRateCombo;
        private System.Windows.Forms.ComboBox comboBox_boardNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private SeeSharpTools.JY.GUI.LED led1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private SeeSharpTools.JY.GUI.StripChart stripChart_weight;
        private SeeSharpTools.JY.GUI.StripChart stripChart_position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private SeeSharpTools.JY.GUI.StripChart stripChart1;
    }
}

