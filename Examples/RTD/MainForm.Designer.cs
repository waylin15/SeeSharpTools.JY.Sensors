namespace SeeSharpTools.Examples
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            SeeSharpTools.JY.GUI.EasyChartXSeries easyChartXSeries1 = new SeeSharpTools.JY.GUI.EasyChartXSeries();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox_dispSensor = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_minR = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_maxR = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_maxDisp = new System.Windows.Forms.NumericUpDown();
            this.groupBox_loadcell = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_maxLoad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_sensitivity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_excitationVolt = new System.Windows.Forms.NumericUpDown();
            this.groupBox_thermistor = new System.Windows.Forms.GroupBox();
            this.numericUpDown_resistorRT = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown_beta = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox_thermocouple = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_cjcTemperature = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.numericUpDown_value = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown_result = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.easyButton1 = new SeeSharpTools.JY.GUI.EasyButton();
            this.easyChartX1 = new SeeSharpTools.JY.GUI.EasyChartX();
            this.checkBox_cjcEnable = new System.Windows.Forms.CheckBox();
            this.groupBox_dispSensor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxDisp)).BeginInit();
            this.groupBox_loadcell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sensitivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_excitationVolt)).BeginInit();
            this.groupBox_thermistor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_resistorRT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_beta)).BeginInit();
            this.groupBox_thermocouple.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cjcTemperature)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_result)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(699, 80);
            this.splitter1.TabIndex = 68;
            this.splitter1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.label4.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(117, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(489, 33);
            this.label4.TabIndex = 70;
            this.label4.Text = "SeeSharpTools.JY.Sensors范例";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "位移传感器",
            "荷重传感器",
            "热电阻RTD_PT100",
            "热敏电阻Thermistor",
            "热电偶Thermocouple"});
            this.comboBox1.Location = new System.Drawing.Point(34, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 24);
            this.comboBox1.TabIndex = 71;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox_dispSensor
            // 
            this.groupBox_dispSensor.Controls.Add(this.label3);
            this.groupBox_dispSensor.Controls.Add(this.label2);
            this.groupBox_dispSensor.Controls.Add(this.label1);
            this.groupBox_dispSensor.Controls.Add(this.numericUpDown_minR);
            this.groupBox_dispSensor.Controls.Add(this.numericUpDown_maxR);
            this.groupBox_dispSensor.Controls.Add(this.numericUpDown_maxDisp);
            this.groupBox_dispSensor.Location = new System.Drawing.Point(3, 3);
            this.groupBox_dispSensor.Name = "groupBox_dispSensor";
            this.groupBox_dispSensor.Size = new System.Drawing.Size(200, 115);
            this.groupBox_dispSensor.TabIndex = 72;
            this.groupBox_dispSensor.TabStop = false;
            this.groupBox_dispSensor.Text = "位移传感器";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "最小电阻值(ohm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "最大电阻值(ohm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "最大位移量(cm)";
            // 
            // numericUpDown_minR
            // 
            this.numericUpDown_minR.Location = new System.Drawing.Point(111, 74);
            this.numericUpDown_minR.Name = "numericUpDown_minR";
            this.numericUpDown_minR.Size = new System.Drawing.Size(78, 21);
            this.numericUpDown_minR.TabIndex = 73;
            // 
            // numericUpDown_maxR
            // 
            this.numericUpDown_maxR.Location = new System.Drawing.Point(111, 47);
            this.numericUpDown_maxR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_maxR.Name = "numericUpDown_maxR";
            this.numericUpDown_maxR.Size = new System.Drawing.Size(78, 21);
            this.numericUpDown_maxR.TabIndex = 73;
            this.numericUpDown_maxR.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDown_maxDisp
            // 
            this.numericUpDown_maxDisp.Location = new System.Drawing.Point(111, 20);
            this.numericUpDown_maxDisp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_maxDisp.Name = "numericUpDown_maxDisp";
            this.numericUpDown_maxDisp.Size = new System.Drawing.Size(78, 21);
            this.numericUpDown_maxDisp.TabIndex = 73;
            this.numericUpDown_maxDisp.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox_loadcell
            // 
            this.groupBox_loadcell.Controls.Add(this.label7);
            this.groupBox_loadcell.Controls.Add(this.numericUpDown_maxLoad);
            this.groupBox_loadcell.Controls.Add(this.label6);
            this.groupBox_loadcell.Controls.Add(this.numericUpDown_sensitivity);
            this.groupBox_loadcell.Controls.Add(this.label5);
            this.groupBox_loadcell.Controls.Add(this.numericUpDown_excitationVolt);
            this.groupBox_loadcell.Location = new System.Drawing.Point(3, 124);
            this.groupBox_loadcell.Name = "groupBox_loadcell";
            this.groupBox_loadcell.Size = new System.Drawing.Size(200, 115);
            this.groupBox_loadcell.TabIndex = 72;
            this.groupBox_loadcell.TabStop = false;
            this.groupBox_loadcell.Text = "荷重传感器";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "激励电压(V)";
            // 
            // numericUpDown_maxLoad
            // 
            this.numericUpDown_maxLoad.Location = new System.Drawing.Point(103, 22);
            this.numericUpDown_maxLoad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_maxLoad.Name = "numericUpDown_maxLoad";
            this.numericUpDown_maxLoad.Size = new System.Drawing.Size(78, 21);
            this.numericUpDown_maxLoad.TabIndex = 73;
            this.numericUpDown_maxLoad.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "灵敏度(mv/V)";
            // 
            // numericUpDown_sensitivity
            // 
            this.numericUpDown_sensitivity.DecimalPlaces = 1;
            this.numericUpDown_sensitivity.Location = new System.Drawing.Point(103, 49);
            this.numericUpDown_sensitivity.Name = "numericUpDown_sensitivity";
            this.numericUpDown_sensitivity.Size = new System.Drawing.Size(78, 21);
            this.numericUpDown_sensitivity.TabIndex = 73;
            this.numericUpDown_sensitivity.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "最大荷重(N)";
            // 
            // numericUpDown_excitationVolt
            // 
            this.numericUpDown_excitationVolt.Location = new System.Drawing.Point(103, 76);
            this.numericUpDown_excitationVolt.Name = "numericUpDown_excitationVolt";
            this.numericUpDown_excitationVolt.Size = new System.Drawing.Size(78, 21);
            this.numericUpDown_excitationVolt.TabIndex = 73;
            this.numericUpDown_excitationVolt.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox_thermistor
            // 
            this.groupBox_thermistor.Controls.Add(this.numericUpDown_resistorRT);
            this.groupBox_thermistor.Controls.Add(this.label9);
            this.groupBox_thermistor.Controls.Add(this.numericUpDown_beta);
            this.groupBox_thermistor.Controls.Add(this.label10);
            this.groupBox_thermistor.Location = new System.Drawing.Point(3, 245);
            this.groupBox_thermistor.Name = "groupBox_thermistor";
            this.groupBox_thermistor.Size = new System.Drawing.Size(200, 115);
            this.groupBox_thermistor.TabIndex = 72;
            this.groupBox_thermistor.TabStop = false;
            this.groupBox_thermistor.Text = "热敏电阻Thermistor";
            // 
            // numericUpDown_resistorRT
            // 
            this.numericUpDown_resistorRT.Location = new System.Drawing.Point(103, 22);
            this.numericUpDown_resistorRT.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_resistorRT.Name = "numericUpDown_resistorRT";
            this.numericUpDown_resistorRT.Size = new System.Drawing.Size(78, 21);
            this.numericUpDown_resistorRT.TabIndex = 73;
            this.numericUpDown_resistorRT.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "beta系数";
            // 
            // numericUpDown_beta
            // 
            this.numericUpDown_beta.Location = new System.Drawing.Point(103, 49);
            this.numericUpDown_beta.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_beta.Name = "numericUpDown_beta";
            this.numericUpDown_beta.Size = new System.Drawing.Size(78, 21);
            this.numericUpDown_beta.TabIndex = 73;
            this.numericUpDown_beta.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "室温电阻(ohm)";
            // 
            // groupBox_thermocouple
            // 
            this.groupBox_thermocouple.Controls.Add(this.checkBox_cjcEnable);
            this.groupBox_thermocouple.Controls.Add(this.label8);
            this.groupBox_thermocouple.Controls.Add(this.numericUpDown_cjcTemperature);
            this.groupBox_thermocouple.Controls.Add(this.label11);
            this.groupBox_thermocouple.Controls.Add(this.comboBox2);
            this.groupBox_thermocouple.Location = new System.Drawing.Point(3, 366);
            this.groupBox_thermocouple.Name = "groupBox_thermocouple";
            this.groupBox_thermocouple.Size = new System.Drawing.Size(200, 115);
            this.groupBox_thermocouple.TabIndex = 72;
            this.groupBox_thermocouple.TabStop = false;
            this.groupBox_thermocouple.Text = "热电偶Thermocouple";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "CJC温度";
            // 
            // numericUpDown_cjcTemperature
            // 
            this.numericUpDown_cjcTemperature.Location = new System.Drawing.Point(103, 49);
            this.numericUpDown_cjcTemperature.Name = "numericUpDown_cjcTemperature";
            this.numericUpDown_cjcTemperature.Size = new System.Drawing.Size(78, 21);
            this.numericUpDown_cjcTemperature.TabIndex = 73;
            this.numericUpDown_cjcTemperature.Value = new decimal(new int[] {
            250,
            0,
            0,
            65536});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "热电偶类型";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "TypeB",
            "TypeE",
            "TypeJ",
            "TypeK",
            "TypeN",
            "TypeR",
            "TypeS",
            "TypeT"});
            this.comboBox2.Location = new System.Drawing.Point(103, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(78, 20);
            this.comboBox2.TabIndex = 71;
            this.comboBox2.Text = "TypeK";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox_dispSensor);
            this.flowLayoutPanel1.Controls.Add(this.groupBox_loadcell);
            this.flowLayoutPanel1.Controls.Add(this.groupBox_thermistor);
            this.flowLayoutPanel1.Controls.Add(this.groupBox_thermocouple);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 144);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(220, 243);
            this.flowLayoutPanel1.TabIndex = 73;
            // 
            // numericUpDown_value
            // 
            this.numericUpDown_value.DecimalPlaces = 8;
            this.numericUpDown_value.Location = new System.Drawing.Point(310, 118);
            this.numericUpDown_value.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_value.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDown_value.Name = "numericUpDown_value";
            this.numericUpDown_value.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown_value.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(310, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 75;
            this.label12.Text = "量测值";
            // 
            // numericUpDown_result
            // 
            this.numericUpDown_result.DecimalPlaces = 5;
            this.numericUpDown_result.Location = new System.Drawing.Point(547, 118);
            this.numericUpDown_result.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_result.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDown_result.Name = "numericUpDown_result";
            this.numericUpDown_result.ReadOnly = true;
            this.numericUpDown_result.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown_result.TabIndex = 74;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(547, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 75;
            this.label13.Text = "计算值";
            // 
            // easyButton1
            // 
            this.easyButton1.Image = ((System.Drawing.Image)(resources.GetObject("easyButton1.Image")));
            this.easyButton1.Location = new System.Drawing.Point(461, 114);
            this.easyButton1.Name = "easyButton1";
            this.easyButton1.PreSetImage = SeeSharpTools.JY.GUI.EasyButton.ButtonPresetImage.Go;
            this.easyButton1.Size = new System.Drawing.Size(54, 25);
            this.easyButton1.TabIndex = 76;
            this.easyButton1.Click += new System.EventHandler(this.easyButton1_Click);
            // 
            // easyChartX1
            // 
            this.easyChartX1.AxisX.AutoScale = true;
            this.easyChartX1.AxisX.AutoZoomReset = false;
            this.easyChartX1.AxisX.Color = System.Drawing.Color.Black;
            this.easyChartX1.AxisX.InitWithScaleView = false;
            this.easyChartX1.AxisX.IsLogarithmic = false;
            this.easyChartX1.AxisX.LabelEnabled = true;
            this.easyChartX1.AxisX.LabelFormat = null;
            this.easyChartX1.AxisX.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisX.MajorGridEnabled = true;
            this.easyChartX1.AxisX.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Solid;
            this.easyChartX1.AxisX.Maximum = 1000D;
            this.easyChartX1.AxisX.Minimum = 0D;
            this.easyChartX1.AxisX.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisX.MinorGridEnabled = false;
            this.easyChartX1.AxisX.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Solid;
            this.easyChartX1.AxisX.Title = "";
            this.easyChartX1.AxisX.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX1.AxisX.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX1.AxisX.ViewMaximum = 1000D;
            this.easyChartX1.AxisX.ViewMinimum = 0D;
            this.easyChartX1.AxisX2.AutoScale = true;
            this.easyChartX1.AxisX2.AutoZoomReset = false;
            this.easyChartX1.AxisX2.Color = System.Drawing.Color.Black;
            this.easyChartX1.AxisX2.InitWithScaleView = false;
            this.easyChartX1.AxisX2.IsLogarithmic = false;
            this.easyChartX1.AxisX2.LabelEnabled = true;
            this.easyChartX1.AxisX2.LabelFormat = null;
            this.easyChartX1.AxisX2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisX2.MajorGridEnabled = true;
            this.easyChartX1.AxisX2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Solid;
            this.easyChartX1.AxisX2.Maximum = 1000D;
            this.easyChartX1.AxisX2.Minimum = 0D;
            this.easyChartX1.AxisX2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisX2.MinorGridEnabled = false;
            this.easyChartX1.AxisX2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Solid;
            this.easyChartX1.AxisX2.Title = "";
            this.easyChartX1.AxisX2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX1.AxisX2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX1.AxisX2.ViewMaximum = 1000D;
            this.easyChartX1.AxisX2.ViewMinimum = 0D;
            this.easyChartX1.AxisY.AutoScale = true;
            this.easyChartX1.AxisY.AutoZoomReset = false;
            this.easyChartX1.AxisY.Color = System.Drawing.Color.Black;
            this.easyChartX1.AxisY.InitWithScaleView = false;
            this.easyChartX1.AxisY.IsLogarithmic = false;
            this.easyChartX1.AxisY.LabelEnabled = true;
            this.easyChartX1.AxisY.LabelFormat = null;
            this.easyChartX1.AxisY.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisY.MajorGridEnabled = true;
            this.easyChartX1.AxisY.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Solid;
            this.easyChartX1.AxisY.Maximum = 3.5D;
            this.easyChartX1.AxisY.Minimum = 0D;
            this.easyChartX1.AxisY.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisY.MinorGridEnabled = false;
            this.easyChartX1.AxisY.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Solid;
            this.easyChartX1.AxisY.Title = "";
            this.easyChartX1.AxisY.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX1.AxisY.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX1.AxisY.ViewMaximum = 3.5D;
            this.easyChartX1.AxisY.ViewMinimum = 0D;
            this.easyChartX1.AxisY2.AutoScale = true;
            this.easyChartX1.AxisY2.AutoZoomReset = false;
            this.easyChartX1.AxisY2.Color = System.Drawing.Color.Black;
            this.easyChartX1.AxisY2.InitWithScaleView = false;
            this.easyChartX1.AxisY2.IsLogarithmic = false;
            this.easyChartX1.AxisY2.LabelEnabled = true;
            this.easyChartX1.AxisY2.LabelFormat = null;
            this.easyChartX1.AxisY2.MajorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisY2.MajorGridEnabled = true;
            this.easyChartX1.AxisY2.MajorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Solid;
            this.easyChartX1.AxisY2.Maximum = 3.5D;
            this.easyChartX1.AxisY2.Minimum = 0D;
            this.easyChartX1.AxisY2.MinorGridColor = System.Drawing.Color.Black;
            this.easyChartX1.AxisY2.MinorGridEnabled = false;
            this.easyChartX1.AxisY2.MinorGridType = SeeSharpTools.JY.GUI.EasyChartXAxis.GridStyle.Solid;
            this.easyChartX1.AxisY2.Title = "";
            this.easyChartX1.AxisY2.TitleOrientation = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextOrientation.Auto;
            this.easyChartX1.AxisY2.TitlePosition = SeeSharpTools.JY.GUI.EasyChartXAxis.AxisTextPosition.Center;
            this.easyChartX1.AxisY2.ViewMaximum = 3.5D;
            this.easyChartX1.AxisY2.ViewMinimum = 0D;
            this.easyChartX1.BackColor = System.Drawing.Color.White;
            this.easyChartX1.ChartAreaBackColor = System.Drawing.Color.Empty;
            this.easyChartX1.CheckInfinity = false;
            this.easyChartX1.CheckNaN = false;
            this.easyChartX1.CheckNegtiveOrZero = false;
            this.easyChartX1.Cumulitive = false;
            this.easyChartX1.Fitting = SeeSharpTools.JY.GUI.EasyChartX.FitType.Range;
            this.easyChartX1.GradientStyle = SeeSharpTools.JY.GUI.EasyChartX.ChartGradientStyle.None;
            this.easyChartX1.LegendBackColor = System.Drawing.Color.Transparent;
            this.easyChartX1.LegendVisible = true;
            easyChartXSeries1.Color = System.Drawing.Color.Red;
            easyChartXSeries1.Marker = SeeSharpTools.JY.GUI.EasyChartXSeries.MarkerType.None;
            easyChartXSeries1.Name = "Series1";
            easyChartXSeries1.Type = SeeSharpTools.JY.GUI.EasyChartXSeries.LineType.FastLine;
            easyChartXSeries1.Visible = true;
            easyChartXSeries1.Width = SeeSharpTools.JY.GUI.EasyChartXSeries.LineWidth.Thin;
            easyChartXSeries1.XPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            easyChartXSeries1.YPlotAxis = SeeSharpTools.JY.GUI.EasyChartXAxis.PlotAxis.Primary;
            this.easyChartX1.LineSeries.Add(easyChartXSeries1);
            this.easyChartX1.Location = new System.Drawing.Point(310, 167);
            this.easyChartX1.Name = "easyChartX1";
            this.easyChartX1.SeriesCount = 1;
            this.easyChartX1.Size = new System.Drawing.Size(356, 238);
            this.easyChartX1.SplitView = false;
            this.easyChartX1.TabIndex = 77;
            this.easyChartX1.XCursor.AutoInterval = true;
            this.easyChartX1.XCursor.Color = System.Drawing.Color.Red;
            this.easyChartX1.XCursor.Interval = 0.001D;
            this.easyChartX1.XCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Zoom;
            this.easyChartX1.XCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX1.XCursor.Value = double.NaN;
            this.easyChartX1.YCursor.AutoInterval = true;
            this.easyChartX1.YCursor.Color = System.Drawing.Color.Red;
            this.easyChartX1.YCursor.Interval = 0.001D;
            this.easyChartX1.YCursor.Mode = SeeSharpTools.JY.GUI.EasyChartXCursor.CursorMode.Disabled;
            this.easyChartX1.YCursor.SelectionColor = System.Drawing.Color.LightGray;
            this.easyChartX1.YCursor.Value = double.NaN;
            // 
            // checkBox_cjcEnable
            // 
            this.checkBox_cjcEnable.AutoSize = true;
            this.checkBox_cjcEnable.Location = new System.Drawing.Point(103, 79);
            this.checkBox_cjcEnable.Name = "checkBox_cjcEnable";
            this.checkBox_cjcEnable.Size = new System.Drawing.Size(66, 16);
            this.checkBox_cjcEnable.TabIndex = 78;
            this.checkBox_cjcEnable.Text = "CJC启用";
            this.checkBox_cjcEnable.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 433);
            this.Controls.Add(this.easyChartX1);
            this.Controls.Add(this.easyButton1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericUpDown_result);
            this.Controls.Add(this.numericUpDown_value);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SeeSharpTools.JY.Sensors范例";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox_dispSensor.ResumeLayout(false);
            this.groupBox_dispSensor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxDisp)).EndInit();
            this.groupBox_loadcell.ResumeLayout(false);
            this.groupBox_loadcell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sensitivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_excitationVolt)).EndInit();
            this.groupBox_thermistor.ResumeLayout(false);
            this.groupBox_thermistor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_resistorRT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_beta)).EndInit();
            this.groupBox_thermocouple.ResumeLayout(false);
            this.groupBox_thermocouple.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cjcTemperature)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox_dispSensor;
        private System.Windows.Forms.NumericUpDown numericUpDown_minR;
        private System.Windows.Forms.NumericUpDown numericUpDown_maxR;
        private System.Windows.Forms.NumericUpDown numericUpDown_maxDisp;
        private System.Windows.Forms.GroupBox groupBox_loadcell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_maxLoad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_sensitivity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_excitationVolt;
        private System.Windows.Forms.GroupBox groupBox_thermistor;
        private System.Windows.Forms.NumericUpDown numericUpDown_resistorRT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown_beta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox_thermocouple;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_cjcTemperature;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numericUpDown_value;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDown_result;
        private System.Windows.Forms.Label label13;
        private SeeSharpTools.JY.GUI.EasyButton easyButton1;
        private SeeSharpTools.JY.GUI.EasyChartX easyChartX1;
        private System.Windows.Forms.CheckBox checkBox_cjcEnable;
    }
}

