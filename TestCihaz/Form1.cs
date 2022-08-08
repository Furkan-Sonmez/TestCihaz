using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.IO.Ports;

namespace TestCihaz
{
    public partial class Form1 : Form
    {
        string dataOUT;
        string sendWith ;
        string dataIn;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);

            btnOpen.Enabled = true;
            btnClose.Enabled = false;

            chBoxDtrEnable.Checked = false;
            serialPort1.DtrEnable = false;

            chBoxRtsEnable.Checked = false;
            serialPort1.RtsEnable = false;
            btnSendData.Enabled = false;

            chBoxWriteLine.Enabled = true;
            chBoxWrite.Enabled = true;
            sendWith = "Write";

            chBoxAddToOldData.Checked = true;
            chBoxAlwaysUpdate.Checked = false;



        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);

                serialPort1.Open();
                progressBar1.Value = 100;

                lblStatusCom.Text = "ON";
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
            }
            catch (Exception err)
            {
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblStatusCom.Text = "OFF";
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;

                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblStatusCom.Text = "OFF";
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                if (serialPort1.IsOpen)
                {
                    dataOUT = tBoxDataOut.Text;
                    if (sendWith == "WriteLine")
                    {
                        serialPort1.WriteLine(dataOUT);
                    }
                    else if (sendWith == "Write")
                    {
                        serialPort1.Write(dataOUT);
                    }
                }
            }
        }

        private void chBoxDtrEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxDtrEnable.Checked) {

                serialPort1.DtrEnable = true; 
            
            }

            else { 
                serialPort1.DtrEnable = false; 
            }
        }

        private void chBoxRtsEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxRtsEnable.Checked)
            {

                serialPort1.RtsEnable = true;

            }

            else
            {
                serialPort1.RtsEnable = false;
            }
        }

        private void btnClearDataOut_Click(object sender, EventArgs e)
        {
            if (tBoxDataOut.Text != "")
            {
                tBoxDataOut.Text = "";
            }
        }

        private void tBoxDataOut_TextChanged(object sender, EventArgs e)
        {
            int dataOUTLength = tBoxDataOut.Text.Length;
            lblDataOutLength.Text = String.Format("{0:00}", dataOUTLength);
            if (chBoxUsingEnter.Checked)
            {
                tBoxDataOut.Text = tBoxDataOut.Text.Replace(Environment.NewLine, "");
            }
        }

        private void chBoxUsingButton_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxUsingButton.Checked)
            {
                btnSendData.Enabled = true;

            }
            else
            {
                btnSendData.Enabled = false;
            }
        }

        private void tBoxDataOut_KeyDown(object sender, KeyEventArgs e)
        {
            if (chBoxUsingEnter.Checked)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (serialPort1.IsOpen)
                    {   
                        dataOUT = tBoxDataOut.Text;
                        if (sendWith == "WriteLine")
                        {
                            serialPort1.WriteLine(dataOUT);
                        }
                        else if (sendWith =="Write") {
                            serialPort1.Write(dataOUT); 
                        }
                    }
                }
            }
        }

        private void chBoxWriteLine_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxWriteLine.Checked)
            {
                sendWith = "WriteLine";
                chBoxWrite.Checked = false;
                chBoxWriteLine.Checked = true;

            }
        }

        private void chBoxWrite_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxWrite.Checked)
            {
                sendWith = "Write";
                chBoxWrite.Checked = true;
                chBoxWriteLine.Checked = false;

            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            int dataInLength = dataIn.Length;
            lblDataInLength.Text = string.Format("{0:00}", dataInLength);
            if (chBoxAlwaysUpdate.Checked)
            {
                tBoxDataıN.Text = dataIn;
            }else if (chBoxAddToOldData.Checked)
            {
                tBoxDataıN.Text += dataIn;
            }
        }

        private void chBoxAlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAlwaysUpdate.Checked)
            {
                chBoxAlwaysUpdate.Checked = true; 
                chBoxAddToOldData.Checked = false;
            }
        }

        private void chBoxAddToOldData_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAddToOldData.Checked)
            {
                chBoxAlwaysUpdate.Checked = false;
                chBoxAddToOldData.Checked = true;
            }
        }

        private void btnClearDataIn_Click(object sender, EventArgs e)
        {
            if(tBoxDataıN.Text != "")
            {
                tBoxDataıN.Text = "";
            }
        }
    }
}
