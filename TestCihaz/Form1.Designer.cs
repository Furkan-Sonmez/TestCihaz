namespace TestCihaz
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chBoxDtrEnable = new System.Windows.Forms.CheckBox();
            this.chBoxRtsEnable = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearDataOut = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chBoxUsingButton = new System.Windows.Forms.CheckBox();
            this.chBoxUsingEnter = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chBoxWriteLine = new System.Windows.Forms.CheckBox();
            this.chBoxWrite = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDataOutLength = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblStatusCom = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tBoxDataıN = new System.Windows.Forms.TextBox();
            this.chBoxAlwaysUpdate = new System.Windows.Forms.CheckBox();
            this.chBoxAddToOldData = new System.Windows.Forms.CheckBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.btnClearDataIn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDataInLength = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chBoxRtsEnable);
            this.groupBox1.Controls.Add(this.chBoxDtrEnable);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxParityBits);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.cBoxBaudRate);
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Kontrol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "COM PORT";
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(129, 153);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(139, 24);
            this.cBoxParityBits.TabIndex = 6;
            this.cBoxParityBits.Text = "None";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(129, 123);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(139, 24);
            this.cBoxStopBits.TabIndex = 5;
            this.cBoxStopBits.Text = "One";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(129, 93);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(139, 24);
            this.cBoxDataBits.TabIndex = 4;
            this.cBoxDataBits.Text = "8";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "921600"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(129, 63);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(139, 24);
            this.cBoxBaudRate.TabIndex = 3;
            this.cBoxBaudRate.Text = "9600";
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(129, 33);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(139, 24);
            this.cBoxCOMPORT.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(16, 21);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(74, 33);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Aç";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(0, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 129);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 101);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(267, 22);
            this.progressBar1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(16, 60);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(6, 21);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(128, 32);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Location = new System.Drawing.Point(6, 21);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(382, 152);
            this.tBoxDataOut.TabIndex = 4;
            this.tBoxDataOut.TextChanged += new System.EventHandler(this.tBoxDataOut_TextChanged);
            this.tBoxDataOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxDataOut_KeyDown);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // chBoxDtrEnable
            // 
            this.chBoxDtrEnable.AutoSize = true;
            this.chBoxDtrEnable.Location = new System.Drawing.Point(15, 190);
            this.chBoxDtrEnable.Name = "chBoxDtrEnable";
            this.chBoxDtrEnable.Size = new System.Drawing.Size(123, 20);
            this.chBoxDtrEnable.TabIndex = 12;
            this.chBoxDtrEnable.Text = "DTR ENABELE";
            this.chBoxDtrEnable.UseVisualStyleBackColor = true;
            this.chBoxDtrEnable.CheckedChanged += new System.EventHandler(this.chBoxDtrEnable_CheckedChanged);
            // 
            // chBoxRtsEnable
            // 
            this.chBoxRtsEnable.AutoSize = true;
            this.chBoxRtsEnable.Location = new System.Drawing.Point(150, 190);
            this.chBoxRtsEnable.Name = "chBoxRtsEnable";
            this.chBoxRtsEnable.Size = new System.Drawing.Size(113, 20);
            this.chBoxRtsEnable.TabIndex = 13;
            this.chBoxRtsEnable.Text = "RTS ENABLE";
            this.chBoxRtsEnable.UseVisualStyleBackColor = true;
            this.chBoxRtsEnable.CheckedChanged += new System.EventHandler(this.chBoxRtsEnable_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.tBoxDataOut);
            this.groupBox3.Location = new System.Drawing.Point(301, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 358);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmitter Kontrol";
            // 
            // btnClearDataOut
            // 
            this.btnClearDataOut.Location = new System.Drawing.Point(6, 59);
            this.btnClearDataOut.Name = "btnClearDataOut";
            this.btnClearDataOut.Size = new System.Drawing.Size(128, 32);
            this.btnClearDataOut.TabIndex = 5;
            this.btnClearDataOut.Text = "Celear Data Out";
            this.btnClearDataOut.UseVisualStyleBackColor = true;
            this.btnClearDataOut.Click += new System.EventHandler(this.btnClearDataOut_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClearDataOut);
            this.groupBox4.Controls.Add(this.btnSendData);
            this.groupBox4.Location = new System.Drawing.Point(6, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(143, 109);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chBoxUsingEnter);
            this.groupBox5.Controls.Add(this.chBoxUsingButton);
            this.groupBox5.Location = new System.Drawing.Point(155, 185);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(121, 91);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // chBoxUsingButton
            // 
            this.chBoxUsingButton.AutoSize = true;
            this.chBoxUsingButton.Location = new System.Drawing.Point(3, 27);
            this.chBoxUsingButton.Name = "chBoxUsingButton";
            this.chBoxUsingButton.Size = new System.Drawing.Size(104, 20);
            this.chBoxUsingButton.TabIndex = 0;
            this.chBoxUsingButton.Text = "Using Button";
            this.chBoxUsingButton.UseVisualStyleBackColor = true;
            this.chBoxUsingButton.CheckedChanged += new System.EventHandler(this.chBoxUsingButton_CheckedChanged);
            // 
            // chBoxUsingEnter
            // 
            this.chBoxUsingEnter.AutoSize = true;
            this.chBoxUsingEnter.Location = new System.Drawing.Point(3, 53);
            this.chBoxUsingEnter.Name = "chBoxUsingEnter";
            this.chBoxUsingEnter.Size = new System.Drawing.Size(105, 20);
            this.chBoxUsingEnter.TabIndex = 1;
            this.chBoxUsingEnter.Text = "Usinng Enter";
            this.chBoxUsingEnter.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chBoxWriteLine);
            this.groupBox6.Controls.Add(this.chBoxWrite);
            this.groupBox6.Location = new System.Drawing.Point(282, 185);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(106, 91);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            // 
            // chBoxWriteLine
            // 
            this.chBoxWriteLine.AutoSize = true;
            this.chBoxWriteLine.Location = new System.Drawing.Point(5, 27);
            this.chBoxWriteLine.Name = "chBoxWriteLine";
            this.chBoxWriteLine.Size = new System.Drawing.Size(88, 20);
            this.chBoxWriteLine.TabIndex = 1;
            this.chBoxWriteLine.Text = "Write Line";
            this.chBoxWriteLine.UseVisualStyleBackColor = true;
            this.chBoxWriteLine.CheckedChanged += new System.EventHandler(this.chBoxWriteLine_CheckedChanged);
            // 
            // chBoxWrite
            // 
            this.chBoxWrite.AutoSize = true;
            this.chBoxWrite.Location = new System.Drawing.Point(5, 53);
            this.chBoxWrite.Name = "chBoxWrite";
            this.chBoxWrite.Size = new System.Drawing.Size(60, 20);
            this.chBoxWrite.TabIndex = 0;
            this.chBoxWrite.Text = "Write";
            this.chBoxWrite.UseVisualStyleBackColor = true;
            this.chBoxWrite.CheckedChanged += new System.EventHandler(this.chBoxWrite_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblDataOutLength);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Location = new System.Drawing.Point(12, 294);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(376, 58);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Data OUT Length : ";
            // 
            // lblDataOutLength
            // 
            this.lblDataOutLength.AutoSize = true;
            this.lblDataOutLength.Location = new System.Drawing.Point(143, 19);
            this.lblDataOutLength.Name = "lblDataOutLength";
            this.lblDataOutLength.Size = new System.Drawing.Size(21, 16);
            this.lblDataOutLength.TabIndex = 7;
            this.lblDataOutLength.Text = "00";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblStatusCom);
            this.groupBox8.Location = new System.Drawing.Point(107, 13);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(172, 82);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Com Port Status";
            // 
            // lblStatusCom
            // 
            this.lblStatusCom.AutoSize = true;
            this.lblStatusCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatusCom.Location = new System.Drawing.Point(50, 31);
            this.lblStatusCom.Name = "lblStatusCom";
            this.lblStatusCom.Size = new System.Drawing.Size(65, 29);
            this.lblStatusCom.TabIndex = 0;
            this.lblStatusCom.Text = "OFF";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox10);
            this.groupBox9.Controls.Add(this.groupBox12);
            this.groupBox9.Controls.Add(this.groupBox13);
            this.groupBox9.Controls.Add(this.tBoxDataıN);
            this.groupBox9.Location = new System.Drawing.Point(723, 17);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(416, 358);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Receiver Kontrol";
            // 
            // tBoxDataıN
            // 
            this.tBoxDataıN.Location = new System.Drawing.Point(6, 21);
            this.tBoxDataıN.Multiline = true;
            this.tBoxDataıN.Name = "tBoxDataıN";
            this.tBoxDataıN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxDataıN.Size = new System.Drawing.Size(382, 152);
            this.tBoxDataıN.TabIndex = 4;
            // 
            // chBoxAlwaysUpdate
            // 
            this.chBoxAlwaysUpdate.AutoSize = true;
            this.chBoxAlwaysUpdate.Location = new System.Drawing.Point(3, 27);
            this.chBoxAlwaysUpdate.Name = "chBoxAlwaysUpdate";
            this.chBoxAlwaysUpdate.Size = new System.Drawing.Size(120, 20);
            this.chBoxAlwaysUpdate.TabIndex = 0;
            this.chBoxAlwaysUpdate.Text = "Always Update";
            this.chBoxAlwaysUpdate.UseVisualStyleBackColor = true;
            this.chBoxAlwaysUpdate.CheckedChanged += new System.EventHandler(this.chBoxAlwaysUpdate_CheckedChanged);
            // 
            // chBoxAddToOldData
            // 
            this.chBoxAddToOldData.AutoSize = true;
            this.chBoxAddToOldData.Location = new System.Drawing.Point(3, 53);
            this.chBoxAddToOldData.Name = "chBoxAddToOldData";
            this.chBoxAddToOldData.Size = new System.Drawing.Size(130, 20);
            this.chBoxAddToOldData.TabIndex = 1;
            this.chBoxAddToOldData.Text = "Add To Old Data";
            this.chBoxAddToOldData.UseVisualStyleBackColor = true;
            this.chBoxAddToOldData.CheckedChanged += new System.EventHandler(this.chBoxAddToOldData_CheckedChanged);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.chBoxAddToOldData);
            this.groupBox12.Controls.Add(this.chBoxAlwaysUpdate);
            this.groupBox12.Location = new System.Drawing.Point(155, 180);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(133, 91);
            this.groupBox12.TabIndex = 6;
            this.groupBox12.TabStop = false;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.btnClearDataIn);
            this.groupBox13.Location = new System.Drawing.Point(6, 179);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(143, 109);
            this.groupBox13.TabIndex = 6;
            this.groupBox13.TabStop = false;
            // 
            // btnClearDataIn
            // 
            this.btnClearDataIn.Location = new System.Drawing.Point(6, 6);
            this.btnClearDataIn.Name = "btnClearDataIn";
            this.btnClearDataIn.Size = new System.Drawing.Size(128, 85);
            this.btnClearDataIn.TabIndex = 5;
            this.btnClearDataIn.Text = "Clear Data IN";
            this.btnClearDataIn.UseVisualStyleBackColor = true;
            this.btnClearDataIn.Click += new System.EventHandler(this.btnClearDataIn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Data IN Length : ";
            // 
            // lblDataInLength
            // 
            this.lblDataInLength.AutoSize = true;
            this.lblDataInLength.Location = new System.Drawing.Point(143, 19);
            this.lblDataInLength.Name = "lblDataInLength";
            this.lblDataInLength.Size = new System.Drawing.Size(21, 16);
            this.lblDataInLength.TabIndex = 7;
            this.lblDataInLength.Text = "00";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblDataInLength);
            this.groupBox10.Controls.Add(this.label8);
            this.groupBox10.Location = new System.Drawing.Point(12, 294);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(376, 58);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 391);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Com Port Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chBoxRtsEnable;
        private System.Windows.Forms.CheckBox chBoxDtrEnable;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblStatusCom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblDataOutLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chBoxWriteLine;
        private System.Windows.Forms.CheckBox chBoxWrite;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chBoxUsingEnter;
        private System.Windows.Forms.CheckBox chBoxUsingButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClearDataOut;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lblDataInLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox chBoxAddToOldData;
        private System.Windows.Forms.CheckBox chBoxAlwaysUpdate;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button btnClearDataIn;
        private System.Windows.Forms.TextBox tBoxDataıN;
    }
}

