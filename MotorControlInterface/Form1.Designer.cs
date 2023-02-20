
namespace MotorControlInterface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RelativeTurnCW = new System.Windows.Forms.Button();
            this.RelativePositionTextCW = new System.Windows.Forms.TextBox();
            this.RelativeSpeedTextCW = new System.Windows.Forms.TextBox();
            this.RelativePositionTextCCW = new System.Windows.Forms.TextBox();
            this.RelativeSpeedTextCCW = new System.Windows.Forms.TextBox();
            this.AbsoluteSpeedTextCCW = new System.Windows.Forms.TextBox();
            this.AbsolutePositionTextCCW = new System.Windows.Forms.TextBox();
            this.AbsolutePositionTextCW = new System.Windows.Forms.TextBox();
            this.AbsoluteTurnCW = new System.Windows.Forms.Button();
            this.TurnHome = new System.Windows.Forms.Button();
            this.CurrenPosition = new System.Windows.Forms.Button();
            this.StopMotor = new System.Windows.Forms.Button();
            this.UpdateAccelerationText = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StopBits = new System.Windows.Forms.ComboBox();
            this.Parity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BaudRate = new System.Windows.Forms.ComboBox();
            this.DataBits = new System.Windows.Forms.ComboBox();
            this.ComPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HexMode = new System.Windows.Forms.RadioButton();
            this.TextMode = new System.Windows.Forms.RadioButton();
            this.ClearTexts = new System.Windows.Forms.Button();
            this.SerialSendText = new System.Windows.Forms.TextBox();
            this.SerialDataArea = new System.Windows.Forms.RichTextBox();
            this.AbsoluteTurnCCW = new System.Windows.Forms.Button();
            this.RelativeTurnCCW = new System.Windows.Forms.Button();
            this.UpdateAcceleration = new System.Windows.Forms.Button();
            this.AbsoluteSpeedTextCW = new System.Windows.Forms.TextBox();
            this.CurrentPositionText = new System.Windows.Forms.TextBox();
            this.UpdateHome = new System.Windows.Forms.Button();
            this.SerialComConnect = new System.Windows.Forms.Button();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdatePortNames = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RelativeTurnCW
            // 
            this.RelativeTurnCW.Location = new System.Drawing.Point(69, 42);
            this.RelativeTurnCW.Name = "RelativeTurnCW";
            this.RelativeTurnCW.Size = new System.Drawing.Size(88, 23);
            this.RelativeTurnCW.TabIndex = 0;
            this.RelativeTurnCW.Text = "Relative Turn +";
            this.RelativeTurnCW.UseVisualStyleBackColor = true;
            this.RelativeTurnCW.Click += new System.EventHandler(this.RelativeTurnCW_Click);
            // 
            // RelativePositionTextCW
            // 
            this.RelativePositionTextCW.Location = new System.Drawing.Point(69, 72);
            this.RelativePositionTextCW.Name = "RelativePositionTextCW";
            this.RelativePositionTextCW.Size = new System.Drawing.Size(88, 20);
            this.RelativePositionTextCW.TabIndex = 1;
            this.RelativePositionTextCW.TextChanged += new System.EventHandler(this.RelativePositionTextCW_TextChanged);
            // 
            // RelativeSpeedTextCW
            // 
            this.RelativeSpeedTextCW.Location = new System.Drawing.Point(69, 99);
            this.RelativeSpeedTextCW.Name = "RelativeSpeedTextCW";
            this.RelativeSpeedTextCW.Size = new System.Drawing.Size(88, 20);
            this.RelativeSpeedTextCW.TabIndex = 3;
            this.RelativeSpeedTextCW.TextChanged += new System.EventHandler(this.RelativeSpeedTextCW_TextChanged);
            // 
            // RelativePositionTextCCW
            // 
            this.RelativePositionTextCCW.Location = new System.Drawing.Point(164, 71);
            this.RelativePositionTextCCW.Name = "RelativePositionTextCCW";
            this.RelativePositionTextCCW.Size = new System.Drawing.Size(86, 20);
            this.RelativePositionTextCCW.TabIndex = 5;
            this.RelativePositionTextCCW.TextChanged += new System.EventHandler(this.RelativePositionTextCCW_TextChanged);
            // 
            // RelativeSpeedTextCCW
            // 
            this.RelativeSpeedTextCCW.Location = new System.Drawing.Point(164, 99);
            this.RelativeSpeedTextCCW.Name = "RelativeSpeedTextCCW";
            this.RelativeSpeedTextCCW.Size = new System.Drawing.Size(86, 20);
            this.RelativeSpeedTextCCW.TabIndex = 6;
            this.RelativeSpeedTextCCW.TextChanged += new System.EventHandler(this.RelativeSpeedTextCCW_TextChanged);
            // 
            // AbsoluteSpeedTextCCW
            // 
            this.AbsoluteSpeedTextCCW.Location = new System.Drawing.Point(421, 97);
            this.AbsoluteSpeedTextCCW.Name = "AbsoluteSpeedTextCCW";
            this.AbsoluteSpeedTextCCW.Size = new System.Drawing.Size(99, 20);
            this.AbsoluteSpeedTextCCW.TabIndex = 14;
            this.AbsoluteSpeedTextCCW.TextChanged += new System.EventHandler(this.AbsoluteSpeedTextCCW_TextChanged);
            // 
            // AbsolutePositionTextCCW
            // 
            this.AbsolutePositionTextCCW.Location = new System.Drawing.Point(421, 72);
            this.AbsolutePositionTextCCW.Name = "AbsolutePositionTextCCW";
            this.AbsolutePositionTextCCW.Size = new System.Drawing.Size(99, 20);
            this.AbsolutePositionTextCCW.TabIndex = 13;
            this.AbsolutePositionTextCCW.TextChanged += new System.EventHandler(this.AbsolutePositionTextCCW_TextChanged);
            // 
            // AbsolutePositionTextCW
            // 
            this.AbsolutePositionTextCW.Location = new System.Drawing.Point(316, 72);
            this.AbsolutePositionTextCW.Name = "AbsolutePositionTextCW";
            this.AbsolutePositionTextCW.Size = new System.Drawing.Size(99, 20);
            this.AbsolutePositionTextCW.TabIndex = 9;
            this.AbsolutePositionTextCW.TextChanged += new System.EventHandler(this.AbsolutePositionTextCW_TextChanged);
            // 
            // AbsoluteTurnCW
            // 
            this.AbsoluteTurnCW.Location = new System.Drawing.Point(316, 41);
            this.AbsoluteTurnCW.Name = "AbsoluteTurnCW";
            this.AbsoluteTurnCW.Size = new System.Drawing.Size(99, 23);
            this.AbsoluteTurnCW.TabIndex = 8;
            this.AbsoluteTurnCW.Text = "Absolute Turn +";
            this.AbsoluteTurnCW.UseVisualStyleBackColor = true;
            this.AbsoluteTurnCW.Click += new System.EventHandler(this.AbsoluteTurnCW_Click);
            // 
            // TurnHome
            // 
            this.TurnHome.Location = new System.Drawing.Point(609, 122);
            this.TurnHome.Name = "TurnHome";
            this.TurnHome.Size = new System.Drawing.Size(112, 23);
            this.TurnHome.TabIndex = 16;
            this.TurnHome.Text = "Turn Home";
            this.TurnHome.UseVisualStyleBackColor = true;
            this.TurnHome.Click += new System.EventHandler(this.TurnHome_Click);
            // 
            // CurrenPosition
            // 
            this.CurrenPosition.Location = new System.Drawing.Point(546, 42);
            this.CurrenPosition.Name = "CurrenPosition";
            this.CurrenPosition.Size = new System.Drawing.Size(112, 23);
            this.CurrenPosition.TabIndex = 19;
            this.CurrenPosition.Text = "Current Position";
            this.CurrenPosition.UseVisualStyleBackColor = true;
            this.CurrenPosition.Click += new System.EventHandler(this.CurrenPosition_Click);
            // 
            // StopMotor
            // 
            this.StopMotor.Location = new System.Drawing.Point(629, 180);
            this.StopMotor.Name = "StopMotor";
            this.StopMotor.Size = new System.Drawing.Size(75, 23);
            this.StopMotor.TabIndex = 21;
            this.StopMotor.Text = "Stop Motor";
            this.StopMotor.UseVisualStyleBackColor = true;
            this.StopMotor.Click += new System.EventHandler(this.StopMotor_Click);
            // 
            // UpdateAccelerationText
            // 
            this.UpdateAccelerationText.Location = new System.Drawing.Point(676, 72);
            this.UpdateAccelerationText.Name = "UpdateAccelerationText";
            this.UpdateAccelerationText.Size = new System.Drawing.Size(112, 20);
            this.UpdateAccelerationText.TabIndex = 22;
            this.UpdateAccelerationText.TextChanged += new System.EventHandler(this.UpdateAccelerationText_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StopBits);
            this.groupBox1.Controls.Add(this.Parity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.BaudRate);
            this.groupBox1.Controls.Add(this.DataBits);
            this.groupBox1.Controls.Add(this.ComPort);
            this.groupBox1.Location = new System.Drawing.Point(22, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 160);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com  Serial Port Settings";
            // 
            // StopBits
            // 
            this.StopBits.FormattingEnabled = true;
            this.StopBits.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.StopBits.Location = new System.Drawing.Point(73, 129);
            this.StopBits.Name = "StopBits";
            this.StopBits.Size = new System.Drawing.Size(121, 21);
            this.StopBits.TabIndex = 42;
            this.StopBits.Text = "Select Stop Bits";
            this.StopBits.SelectedIndexChanged += new System.EventHandler(this.StopBits_SelectedIndexChanged);
            // 
            // Parity
            // 
            this.Parity.FormattingEnabled = true;
            this.Parity.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.Parity.Location = new System.Drawing.Point(73, 102);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(121, 21);
            this.Parity.TabIndex = 41;
            this.Parity.Text = "Select Parity";
            this.Parity.SelectedIndexChanged += new System.EventHandler(this.Parity_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Stop Bits:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Parity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Data Bits:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Baud Rate:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "COM Port:";
            // 
            // BaudRate
            // 
            this.BaudRate.FormattingEnabled = true;
            this.BaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BaudRate.Location = new System.Drawing.Point(73, 50);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(121, 21);
            this.BaudRate.TabIndex = 37;
            this.BaudRate.Text = "Select Baud Rate";
            this.BaudRate.SelectedIndexChanged += new System.EventHandler(this.BaudRate_SelectedIndexChanged_1);
            // 
            // DataBits
            // 
            this.DataBits.FormattingEnabled = true;
            this.DataBits.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.DataBits.Location = new System.Drawing.Point(73, 77);
            this.DataBits.Name = "DataBits";
            this.DataBits.Size = new System.Drawing.Size(121, 21);
            this.DataBits.TabIndex = 8;
            this.DataBits.Text = "Select Data Bits";
            this.DataBits.SelectedIndexChanged += new System.EventHandler(this.DataBits_SelectedIndexChanged);
            // 
            // ComPort
            // 
            this.ComPort.FormattingEnabled = true;
            this.ComPort.Location = new System.Drawing.Point(73, 23);
            this.ComPort.Name = "ComPort";
            this.ComPort.Size = new System.Drawing.Size(121, 21);
            this.ComPort.TabIndex = 0;
            this.ComPort.Text = "Select Port Name";
            this.ComPort.SelectedIndexChanged += new System.EventHandler(this.ComPort_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HexMode);
            this.groupBox2.Controls.Add(this.TextMode);
            this.groupBox2.Location = new System.Drawing.Point(22, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 70);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Mode";
            // 
            // HexMode
            // 
            this.HexMode.AutoSize = true;
            this.HexMode.Location = new System.Drawing.Point(38, 42);
            this.HexMode.Name = "HexMode";
            this.HexMode.Size = new System.Drawing.Size(44, 17);
            this.HexMode.TabIndex = 31;
            this.HexMode.TabStop = true;
            this.HexMode.Text = "Hex";
            this.HexMode.UseVisualStyleBackColor = true;
            this.HexMode.CheckedChanged += new System.EventHandler(this.HexMode_CheckedChanged);
            // 
            // TextMode
            // 
            this.TextMode.AutoSize = true;
            this.TextMode.Location = new System.Drawing.Point(38, 19);
            this.TextMode.Name = "TextMode";
            this.TextMode.Size = new System.Drawing.Size(46, 17);
            this.TextMode.TabIndex = 30;
            this.TextMode.TabStop = true;
            this.TextMode.Text = "Text";
            this.TextMode.UseVisualStyleBackColor = true;
            this.TextMode.CheckedChanged += new System.EventHandler(this.TextMode_CheckedChanged);
            // 
            // ClearTexts
            // 
            this.ClearTexts.Location = new System.Drawing.Point(458, 414);
            this.ClearTexts.Name = "ClearTexts";
            this.ClearTexts.Size = new System.Drawing.Size(75, 23);
            this.ClearTexts.TabIndex = 27;
            this.ClearTexts.Text = "Clear";
            this.ClearTexts.UseVisualStyleBackColor = true;
            this.ClearTexts.Click += new System.EventHandler(this.ClearTexts_Click);
            // 
            // SerialSendText
            // 
            this.SerialSendText.Location = new System.Drawing.Point(228, 388);
            this.SerialSendText.Name = "SerialSendText";
            this.SerialSendText.Size = new System.Drawing.Size(305, 20);
            this.SerialSendText.TabIndex = 28;
            this.SerialSendText.TextChanged += new System.EventHandler(this.SerialSendText_TextChanged);
            // 
            // SerialDataArea
            // 
            this.SerialDataArea.Location = new System.Drawing.Point(228, 151);
            this.SerialDataArea.Name = "SerialDataArea";
            this.SerialDataArea.Size = new System.Drawing.Size(305, 231);
            this.SerialDataArea.TabIndex = 29;
            this.SerialDataArea.Text = "";
            this.SerialDataArea.TextChanged += new System.EventHandler(this.SerialDataArea_TextChanged);
            // 
            // AbsoluteTurnCCW
            // 
            this.AbsoluteTurnCCW.Location = new System.Drawing.Point(421, 41);
            this.AbsoluteTurnCCW.Name = "AbsoluteTurnCCW";
            this.AbsoluteTurnCCW.Size = new System.Drawing.Size(99, 23);
            this.AbsoluteTurnCCW.TabIndex = 30;
            this.AbsoluteTurnCCW.Text = "Absolute Turn -";
            this.AbsoluteTurnCCW.UseVisualStyleBackColor = true;
            this.AbsoluteTurnCCW.Click += new System.EventHandler(this.AbsoluteTurnCCW_Click);
            // 
            // RelativeTurnCCW
            // 
            this.RelativeTurnCCW.Location = new System.Drawing.Point(163, 42);
            this.RelativeTurnCCW.Name = "RelativeTurnCCW";
            this.RelativeTurnCCW.Size = new System.Drawing.Size(86, 23);
            this.RelativeTurnCCW.TabIndex = 31;
            this.RelativeTurnCCW.Text = "Relative Turn -";
            this.RelativeTurnCCW.UseVisualStyleBackColor = true;
            this.RelativeTurnCCW.Click += new System.EventHandler(this.RelativeTurnCCW_Click);
            // 
            // UpdateAcceleration
            // 
            this.UpdateAcceleration.Location = new System.Drawing.Point(676, 43);
            this.UpdateAcceleration.Name = "UpdateAcceleration";
            this.UpdateAcceleration.Size = new System.Drawing.Size(112, 23);
            this.UpdateAcceleration.TabIndex = 32;
            this.UpdateAcceleration.Text = "Update Acceleration";
            this.UpdateAcceleration.UseVisualStyleBackColor = true;
            this.UpdateAcceleration.Click += new System.EventHandler(this.UpdateAcceleration_Click);
            // 
            // AbsoluteSpeedTextCW
            // 
            this.AbsoluteSpeedTextCW.Location = new System.Drawing.Point(316, 97);
            this.AbsoluteSpeedTextCW.Name = "AbsoluteSpeedTextCW";
            this.AbsoluteSpeedTextCW.Size = new System.Drawing.Size(99, 20);
            this.AbsoluteSpeedTextCW.TabIndex = 33;
            this.AbsoluteSpeedTextCW.TextChanged += new System.EventHandler(this.AbsoluteSpeedTextCW_TextChanged);
            // 
            // CurrentPositionText
            // 
            this.CurrentPositionText.Location = new System.Drawing.Point(546, 71);
            this.CurrentPositionText.Name = "CurrentPositionText";
            this.CurrentPositionText.Size = new System.Drawing.Size(112, 20);
            this.CurrentPositionText.TabIndex = 34;
            this.CurrentPositionText.TextChanged += new System.EventHandler(this.CurrentPositionText_TextChanged);
            // 
            // UpdateHome
            // 
            this.UpdateHome.Location = new System.Drawing.Point(609, 151);
            this.UpdateHome.Name = "UpdateHome";
            this.UpdateHome.Size = new System.Drawing.Size(112, 23);
            this.UpdateHome.TabIndex = 35;
            this.UpdateHome.Text = "Update Home";
            this.UpdateHome.UseVisualStyleBackColor = true;
            this.UpdateHome.Click += new System.EventHandler(this.UpdateHome_Click);
            // 
            // SerialComConnect
            // 
            this.SerialComConnect.Location = new System.Drawing.Point(22, 301);
            this.SerialComConnect.Name = "SerialComConnect";
            this.SerialComConnect.Size = new System.Drawing.Size(101, 60);
            this.SerialComConnect.TabIndex = 36;
            this.SerialComConnect.Text = "Connect";
            this.SerialComConnect.UseVisualStyleBackColor = true;
            this.SerialComConnect.Click += new System.EventHandler(this.SerialComConnect_Click);
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(228, 414);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(75, 23);
            this.ButtonSend.TabIndex = 37;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Speed";
            // 
            // UpdatePortNames
            // 
            this.UpdatePortNames.Location = new System.Drawing.Point(129, 301);
            this.UpdatePortNames.Name = "UpdatePortNames";
            this.UpdatePortNames.Size = new System.Drawing.Size(93, 60);
            this.UpdatePortNames.TabIndex = 43;
            this.UpdatePortNames.Text = "Update Ports";
            this.UpdatePortNames.UseVisualStyleBackColor = true;
            this.UpdatePortNames.Click += new System.EventHandler(this.UpdatePortNames_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdatePortNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.SerialComConnect);
            this.Controls.Add(this.UpdateHome);
            this.Controls.Add(this.CurrentPositionText);
            this.Controls.Add(this.AbsoluteSpeedTextCW);
            this.Controls.Add(this.UpdateAcceleration);
            this.Controls.Add(this.RelativeTurnCCW);
            this.Controls.Add(this.AbsoluteTurnCCW);
            this.Controls.Add(this.SerialDataArea);
            this.Controls.Add(this.SerialSendText);
            this.Controls.Add(this.ClearTexts);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UpdateAccelerationText);
            this.Controls.Add(this.StopMotor);
            this.Controls.Add(this.CurrenPosition);
            this.Controls.Add(this.TurnHome);
            this.Controls.Add(this.AbsoluteSpeedTextCCW);
            this.Controls.Add(this.AbsolutePositionTextCCW);
            this.Controls.Add(this.AbsolutePositionTextCW);
            this.Controls.Add(this.AbsoluteTurnCW);
            this.Controls.Add(this.RelativeSpeedTextCCW);
            this.Controls.Add(this.RelativePositionTextCCW);
            this.Controls.Add(this.RelativeSpeedTextCW);
            this.Controls.Add(this.RelativePositionTextCW);
            this.Controls.Add(this.RelativeTurnCW);
            this.Name = "Form1";
            this.Text = "Step Motor Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button RelativeTurnCW;
        public System.Windows.Forms.Button AbsoluteTurnCW;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox RelativePositionTextCW;
        public System.Windows.Forms.TextBox RelativeSpeedTextCW;
        public System.Windows.Forms.TextBox RelativePositionTextCCW;
        public System.Windows.Forms.TextBox RelativeSpeedTextCCW;
        public System.Windows.Forms.TextBox AbsoluteSpeedTextCCW;
        public System.Windows.Forms.TextBox AbsolutePositionTextCCW;
        public System.Windows.Forms.TextBox AbsolutePositionTextCW;
        public System.Windows.Forms.Button TurnHome;
        public System.Windows.Forms.Button CurrenPosition;
        public System.Windows.Forms.Button StopMotor;
        public System.Windows.Forms.TextBox UpdateAccelerationText;
        public System.Windows.Forms.Button ClearTexts;
        public System.Windows.Forms.ComboBox DataBits;
        public System.Windows.Forms.ComboBox ComPort;
        public System.Windows.Forms.TextBox SerialSendText;
        public System.Windows.Forms.RichTextBox SerialDataArea;
        public System.Windows.Forms.RadioButton HexMode;
        public System.Windows.Forms.RadioButton TextMode;
        public System.Windows.Forms.Button AbsoluteTurnCCW;
        public System.Windows.Forms.Button RelativeTurnCCW;
        public System.Windows.Forms.Button UpdateAcceleration;
        public System.Windows.Forms.TextBox AbsoluteSpeedTextCW;
        public System.Windows.Forms.TextBox CurrentPositionText;
        public System.Windows.Forms.Button UpdateHome;
        public System.Windows.Forms.Button SerialComConnect;
        public System.Windows.Forms.ComboBox BaudRate;
        public System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StopBits;
        private System.Windows.Forms.ComboBox Parity;
        private System.Windows.Forms.Button UpdatePortNames;
    }
}

