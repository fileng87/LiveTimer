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
using System.Threading;

namespace LiveTimer
{
    public partial class UCPortSetting : UserControl
    {
        public UCPortSetting()
        {
            InitializeComponent();
        }

        private void UCPortSetting_Load(object sender, EventArgs e)
        {
            string[] baud = { "300", "1200", "2400", "9600", "19200", "38400", "115200" };
            comboBox2.Items.AddRange(baud);

            comboBox2.Text = "9600";

            comboBox1.Items.AddRange(SerialPort.GetPortNames());
        }

        private void Button1(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    richTextBox1.Clear();
                    button1.Text = "連接";
                    comboBox1.Enabled = true;
                    comboBox2.Enabled = true;
                    textBox1.Enabled = false;
                    button2.Enabled = false;
                }
                else
                {
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    textBox1.Enabled = true;
                    button2.Enabled = true;
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Open();
                    button1.Text = "中斷連接";
                }
            }
            catch (Exception ex)
            {
                serialPort1 = new SerialPort();
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                System.Media.SystemSounds.Beep.Play();
                button1.Text = "連接";
                MessageBox.Show(ex.Message);
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                textBox1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();

            Calldelegate(indata);
        }

        private void Calldelegate(string str)
        {
            this.Invoke(new _updateForm(updateForm), str);
        }

        public delegate void _updateForm(string str);

        private void updateForm(string str)
        {
            richTextBox1.AppendText(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(textBox1.Text);
                    textBox1.Clear();
                }
            }
            catch (Exception ex)
            {
                serialPort1.Close();
                serialPort1 = new System.IO.Ports.SerialPort();
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                System.Media.SystemSounds.Beep.Play();
                button1.Text = "連接";
                MessageBox.Show(ex.Message);
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                textBox1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button2_Click(button2, new EventArgs());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
