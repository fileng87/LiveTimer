﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace LiveTimer
{
    public partial class UCStartTime : UserControl
    {
        public UCStartTime()
        {
            InitializeComponent();
        }
        public int shh, smm, sss;
        public bool chackflag;
        private DateTime StartTime;
        public bool zerotime = false;

        public string Time()
        {
            return lab_Time.Text;
        }

        public string Time_()
        {
            return zerotime ? "00:00:00" : lab_Time.Text;
        }

        private void StartTime_Load(object sender, EventArgs e)
        {
            txt_H.Text = DateTime.Now.Hour.ToString();
            txt_M.Text = DateTime.Now.Minute.ToString();
            txt_S.Text = DateTime.Now.Second.ToString();
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
            StartTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(txt_H.Text), int.Parse(txt_M.Text), int.Parse(txt_S.Text));
            timer1.Start();
            timer2.Start();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            long elapsedTicks = Math.Abs(DateTime.Now.Ticks - StartTime.Ticks);
            long chack = DateTime.Now.Ticks - StartTime.Ticks;
            TimeSpan elapsedSpan = new TimeSpan(elapsedTicks);
            shh = elapsedSpan.Hours;
            smm = elapsedSpan.Minutes;
            sss = elapsedSpan.Seconds;
            string h = elapsedSpan.Hours.ToString().PadLeft(2, '0');
            string m = elapsedSpan.Minutes.ToString().PadLeft(2, '0');
            string s = elapsedSpan.Seconds.ToString().PadLeft(2, '0');
            lab_Time.Text = $"{h}:{m}:{s}";
            if (chack <= 0) {
                chackflag = false;
                zerotime = false;
            } else if(chack>0){
                chackflag = true;
                timer2.Stop();
                zerotime = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string path = textBox1.Text == "" ? Application.StartupPath + @"\StartTime.txt" : textBox1.Text + @"\StartTime.txt";
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(lab_Time.Text);
                    fs.WriteAsync(info, 0, info.Length);
                }
            }
            else
            {
                using(StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(lab_Time.Text);
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_H.Text = DateTime.Now.Hour.ToString().PadLeft(2, '0');
            txt_M.Text = DateTime.Now.Minute.ToString().PadLeft(2, '0');
            txt_S.Text = DateTime.Now.Second.ToString().PadLeft(2, '0');
            timer1.Stop();
            lab_Time.Text = $"00:00:00";
        }

        private void pnl_title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_contral_Paint(object sender, PaintEventArgs e)
        {

        }

        public int Necolor()
        {
            if (chackflag)
            {
                lab_Time.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                return 0;
                
            }
            else
            {
                if (shh == 0 && smm == 0 && sss <= 10)
                {
                    lab_Time.ForeColor = ColorTranslator.FromHtml("#FF8C8C");
                    return 3;
                }
                else if (shh == 0 && smm == 0 && sss <= 30)
                {
                    lab_Time.ForeColor = ColorTranslator.FromHtml("#FFFF8C");
                    return 2;
                }
                else if (shh == 0 && smm == 0 && sss <= 59)
                {
                    lab_Time.ForeColor = ColorTranslator.FromHtml("#8CFF8C");
                    return 1;
                }
                else
                {
                    lab_Time.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
                    return 0;
                }
            }
        }

        private void serverData(string data, HttpListener listener)
        {
            HttpListenerContext context = listener.GetContext();
            HttpListenerRequest request = context.Request;
            HttpListenerResponse response = context.Response;
            response.StatusCode = 200;
            response.ContentType = "text/plain";
            response.SendChunked = true;
            byte[] info = new UTF8Encoding(true).GetBytes(data);
            response.OutputStream.Write(info, 0, info.Length);
            response.OutputStream.Close();
        }
    }
}
