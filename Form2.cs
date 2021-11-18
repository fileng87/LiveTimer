using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveTimer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        bool s = true;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void NowTime(string time)
        {
            label1.Text = time;
        }

        public void SetTime(string nowtime)
        {
            label2.Text = nowtime;
        }

        public void StartTime(string nowtime)
        {
            label3.Text = nowtime;
        }

        public void EndTime(string nowtime)
        {
            label4.Text = nowtime;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11 && s == true)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                label1.Font = label2.Font = label3.Font = label4.Font = new Font(label1.Font.FontFamily, label1.Font.Size + 25);
                s = false;
            }
            else if ((e.KeyCode == Keys.F11 || e.KeyCode == Keys.Escape) && s == false)
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.WindowState = FormWindowState.Normal;
                label1.Font = label2.Font = label3.Font = label4.Font = new Font(label1.Font.FontFamily, label1.Font.Size - 25);
                s = true;
            }
        }
    }
}
