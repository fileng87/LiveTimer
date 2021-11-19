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

        private void btn_reset_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    button1.Text = "連接";
                    comboBox1.Enabled = true;
                    comboBox2.Enabled = true;
                }
                else
                {
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
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
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
    }
}
