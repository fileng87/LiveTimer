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
    public partial class UCEndTime : UserControl
    {
        public UCEndTime()
        {
            InitializeComponent();
        }

        private DateTime EndTime;

        public string Time()
        {
            return lab_Time.Text;
        }

        private int checknum(int temp)
        {
            if (temp >= 60)
            {
                return 59;
            }
            else if (temp < 0)
            {
                return 0;
            }
            return temp;
        }

        private int checknum_H(int temp)
        {
            if (temp >= 24)
            {
                return 23;
            }
            else if (temp < 0)
            {
                return 0;
            }
            return temp;
        }

        private void btn_H_Sub_Click(object sender, EventArgs e)
        {
            txt_H.Text = checknum_H(int.Parse(txt_H.Text) - 1).ToString();
        }

        private void btn_H_Add_Click(object sender, EventArgs e)
        {
            txt_H.Text = checknum_H(int.Parse(txt_H.Text) + 1).ToString();
        }

        private void btn_M_Sub_Click(object sender, EventArgs e)
        {
            txt_M.Text = checknum(int.Parse(txt_M.Text) - 1).ToString();
        }

        private void btn_M_Add_Click(object sender, EventArgs e)
        {
            txt_M.Text = checknum(int.Parse(txt_M.Text) + 1).ToString();
        }

        private void btn_S_Sub_Click(object sender, EventArgs e)
        {
            txt_S.Text = checknum(int.Parse(txt_S.Text) - 1).ToString();
        }

        private void btn_S_Add_Click(object sender, EventArgs e)
        {
            txt_S.Text = checknum(int.Parse(txt_S.Text) + 1).ToString();
        }

        private void txt_H_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_H.Text, out int x)) return;
            txt_H.Text = checknum_H(int.Parse(txt_H.Text)).ToString();
        }

        private void txt_M_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_M.Text, out int x)) return;
            txt_M.Text = checknum(int.Parse(txt_M.Text)).ToString();
        }

        private void txt_S_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_S.Text, out int x)) return;
            txt_S.Text = checknum(int.Parse(txt_S.Text)).ToString();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            EndTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(txt_H.Text), int.Parse(txt_M.Text), int.Parse(txt_S.Text));
            timer1.Start();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            long elapsedTicks = Math.Abs(DateTime.Now.Ticks - EndTime.Ticks);
            TimeSpan elapsedSpan = new TimeSpan(elapsedTicks);
            string h = elapsedSpan.Hours.ToString().PadLeft(2, '0');
            string m = elapsedSpan.Minutes.ToString().PadLeft(2, '0');
            string s = elapsedSpan.Seconds.ToString().PadLeft(2, '0');
            lab_Time.Text = $"{h}:{m}:{s}";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_H.Text = txt_M.Text = txt_S.Text = "0";
            timer1.Stop();
            lab_Time.Text = $"00:00:00";
        }
    }
}
