using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace MotorControlInterface
{
    public partial class Form1 : Form
    {
        readonly SerialPort Port = new SerialPort();
        public Form1()
        {
            InitializeComponent();
        }

        private void RelativeTurnCW_Click(object sender, EventArgs e)
        {

        }

        private void AbsoluteTurnCW_Click(object sender, EventArgs e)
        {

        }

        private void AbsoluteSpeedTextCCW_TextChanged(object sender, EventArgs e)
        {

        }

        private void TurnHome_Click(object sender, EventArgs e)
        {
            TurnHome.Enabled = false;
            CurrenPosition.Enabled = true;
            if (Port.IsOpen)
            {
                try
                {
                    Port.Write("1" + "A" + "\n");
                    //Port.Write("1" + "A" + "u"); //To Try Hal Interrupt
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void StopMotor_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdatePorts();

            CheckForIllegalCrossThreadCalls = false;
        }

        private void UpdatePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                ComPort.Items.Add(port);
            }
            
        }

        private void HexMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AbsolutePositionTextCCW_TextChanged(object sender, EventArgs e)
        {

        }

        private void CurrenPosition_Click(object sender, EventArgs e)
        {
            TurnHome.Enabled = true;
            CurrenPosition.Enabled = false;
            if (Port.IsOpen)
            {
                try
                {
                    Port.Write("3" + "C" + "\n");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void UpdateAccelerationText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AbsolutePositionTextCW_TextChanged(object sender, EventArgs e)
        {

        }

        private void RelativePositionTextCCW_TextChanged(object sender, EventArgs e)
        {

        }

        private void RelativeSpeedTextCCW_TextChanged(object sender, EventArgs e)
        {

        }

        private void RelativePositionTextCW_TextChanged(object sender, EventArgs e)
        {

        }

        private void RelativeSpeedTextCW_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DataBits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ClearTexts_Click(object sender, EventArgs e)
        {
            SerialDataArea.Clear();
            SerialSendText.Clear();
        }

        private void SerialSendText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SerialDataArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void AbsoluteTurnCCW_Click(object sender, EventArgs e)
        {

        }

        private void RelativeTurnCCW_Click(object sender, EventArgs e)
        {

        }

        private void UpdateAcceleration_Click(object sender, EventArgs e)
        {
            UpdateHome.Enabled = true;
            UpdateAcceleration.Enabled = false;
            if (Port.IsOpen)
            {
                try
                {
                    Port.Write("4" + "D" + "\n");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void AbsoluteSpeedTextCW_TextChanged(object sender, EventArgs e)
        {

        }

        private void CurrentPositionText_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateHome_Click(object sender, EventArgs e)
        {
            UpdateAcceleration.Enabled = true;
            UpdateHome.Enabled = false;
            if (Port.IsOpen)
            {
                try
                {
                    Port.Write("2" + "B" + "\n");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        
        private void SerialComConnect_Click(object sender, EventArgs e)
        {
            if (Port.IsOpen)
            {
                Disconnect();
            }
            else
            {
                Connect();
            }
        }

        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var serialPort = (SerialPort)sender;
            var data = serialPort.ReadExisting();
            SetText(data);
        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            //invokeRequired required compares the thread ID of the calling thread to the thread of the creating thread.
            // if these threads are different, it returns true
            if (this.SerialDataArea.InvokeRequired)
            {
                SerialDataArea.ForeColor = Color.Green;  

                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.SerialDataArea.AppendText(text);
            }
        }

        private void BaudRate_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            SendData();
        }

        private void StopBits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Parity_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void UpdatePortNames_Click(object sender, EventArgs e)
        {
            UpdatePorts();
        }

        
        private void Connect()
        {
            bool error = false;

            // Check if all settings have been selected

            if (ComPort.SelectedIndex != -1 & BaudRate.SelectedIndex != -1 & Parity.SelectedIndex != -1 & DataBits.SelectedIndex != -1 & StopBits.SelectedIndex != -1)
            {
             
                Port.PortName = ComPort.Text;
                Port.BaudRate = int.Parse(BaudRate.Text);      //convert Text to Integer
                Port.Parity = (Parity)Enum.Parse(typeof(Parity), Parity.Text); //convert Text to Parity
                Port.DataBits = int.Parse(DataBits.Text);        //convert Text to Integer
                Port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), StopBits.Text);  //convert Text to stop bits

                try  
                {
                    //Open Port
                    Port.Open();
                    Port.DataReceived += SerialPortDataReceived;  //Check for received data. 
                }
                catch (UnauthorizedAccessException) { error = true; }
                catch (System.IO.IOException) { error = true; }
                catch (ArgumentException) { error = true; }

                if (error) MessageBox.Show(this, "Could not open the COM port. Most likely it is already in use, has been removed, or is unavailable.", "COM Port unavailable", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                MessageBox.Show("Please select all the COM Serial Port Settings!", "Serial Port Interface", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            //if the port is open, Change the Connect button to disconnect, enable the send button.
            //and disable the groupBox to prevent changing configuration of an open port.
            if (Port.IsOpen)
            {
                SerialComConnect.Text = "Disconnect";
                ButtonSend.Enabled = true;
                if (!TextMode.Checked & !HexMode.Checked)  //if no data mode is selected, then select text mode by default
                {                                          //user does not have to select hex or text mode 
                    TextMode.Checked = true;
                }
                groupBox1.Enabled = false;                  //while connected, settings can not be changed


            }
        }

        private void Disconnect()
        {
            Port.Close();
            SerialComConnect.Text = "Connect";
            ButtonSend.Enabled = false;
            groupBox1.Enabled = true;

        }

        private void SendData()
        {
            bool error = false;
            if (TextMode.Checked == true)       
            {
                // Send the user's text to the port 
                Port.Write(SerialSendText.Text);

                
                SerialDataArea.ForeColor = Color.Green;                
                SerialSendText.Clear();                   

            }
            else                    
            {
                try
                {
                    // Convert the user's string of hex digits (example: E1 FF 1B) to a byte array
                    byte[] data = HexStringToByteArray(SerialSendText.Text);

                    // Send the binary data out the port
                    Port.Write(data, 0, data.Length);

                    // Show the hex digits on in the terminal window
                    SerialDataArea.ForeColor = Color.Blue;  
                    SerialDataArea.AppendText(SerialSendText.Text.ToUpper() + "\n");
                    SerialSendText.Clear();                         
                }
                catch (FormatException) { error = true; }

                
                catch (ArgumentException) { error = true; }

                if (error) MessageBox.Show(this, "Not properly formatted hex string: " + SerialSendText.Text + "\n" + "example: E1 FF 1B", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Port.IsOpen) Port.Close();  //close the port if open when exiting the application.
        }
    }
}
