using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.IO;
using System.Net;

namespace LiveTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            MouseDown += new MouseEventHandler(pnl_top_MouseDown);
            MouseMove += new MouseEventHandler(pnl_top_MouseMove);
            MouseUp += new MouseEventHandler(pnl_top_MouseUp);
        }

        public Point downPoint = Point.Empty;

        private UCSetTime setTime = new UCSetTime();
        private UCStartTime startTime = new UCStartTime();
        private UCEndTime endTime = new UCEndTime();
        private UCPortSetting UCPortSetting = new UCPortSetting();

        public Form2 fm = new Form2();

        private bool s = false;

        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = new Point(e.X, e.Y);

        }

        private void pnl_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint != Point.Empty)
                Location = new Point(Left + e.X - downPoint.X, Top + e.Y - downPoint.Y);
        }

        private void pnl_top_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                downPoint = Point.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_setTime_Click(null, null);
            timer1.Start();
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8080/");
            listener.Prefixes.Add("http://*:8080/");
            listener.Start();
            while (true)
            {
                serverData(startTime.Time_(), listener);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string h = DateTime.Now.Hour.ToString().PadLeft(2, '0');
            string m = DateTime.Now.Minute.ToString().PadLeft(2, '0');
            string s = DateTime.Now.Second.ToString().PadLeft(2, '0');

            lab_nowTime.Text = $"現在時間：{h}:{m}:{s}";

            fm.NowTime($"{h}:{m}:{s}");
            fm.SetTime(setTime.Time());
            fm.StartTime(startTime.Time());
            fm.EndTime(endTime.Time());
            fm.settimered(setTime.Necolor());
            fm.settimeredstart(startTime.Necolor());
            fm.settimeredend(endTime.Necolor());
        }
       
            private void setBtn(Button btn)
        {
            pnl_btn.Visible = true;
            pnl_btn.Height = btn.Height;
            pnl_btn.Top = btn.Top;
            pnl_btn.Left = btn.Left;
            btn.BackColor = this.BackColor;
        }

        private void btnReset()
        {
            btn_setTime.BackColor = Color.FromArgb(38, 38, 38);
            btn_startTime.BackColor = Color.FromArgb(38, 38, 38);
            btn_endTime.BackColor = Color.FromArgb(38, 38, 38);
            btn_SerialPortSetting.BackColor = Color.FromArgb(38, 38, 38);
        }

        private void btn_setTime_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_startTime_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_endTime_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            fm.Close();
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void openUserContral(UserControl uc)
        {
            uc.BorderStyle = BorderStyle.None;
            uc.Dock = DockStyle.Fill;
            this.pnl_default.Controls.Add(uc);
            this.pnl_default.Tag = uc;
            uc.BringToFront();
            uc.Show();
        }

        private void btn_setTime_Click(object sender, EventArgs e)
        {
            btnReset();
            setBtn(btn_setTime);
            lab_titel.Text = "距離切換剩餘";
            openUserContral(setTime);
            pictureBox1.Image = LiveTimer.Properties.Resources.Time_png;
        }

        private void btn_startTime_Click(object sender, EventArgs e)
        {
            btnReset();
            setBtn(btn_startTime);
            lab_titel.Text = "距離開始的時間";
            openUserContral(startTime);
            pictureBox1.Image = LiveTimer.Properties.Resources.Time_png;
        }

        private void btn_endTime_Click(object sender, EventArgs e)
        {
            btnReset();
            setBtn(btn_endTime);
            lab_titel.Text = "距離結束時間";
            openUserContral(endTime);
            pictureBox1.Image = LiveTimer.Properties.Resources.Time_png;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if(s != true)
            {
                btn_show.Text = "關閉投影";
                if (fm != null)
                {
                    fm.Close();
                }
                fm = new Form2();
                fm.TopLevel = true;
                fm.Show();
                s = true;
            }
            else
            {
                btn_show.Text = "顯示投影";
                fm.Close();
                s = false;
            }
        }

        private void pnl_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_SerialPortSetting_Click(object sender, EventArgs e)
        {
            btnReset();
            setBtn(btn_SerialPortSetting);
            lab_titel.Text = "SerialPortSetting";
            openUserContral(UCPortSetting);
            pictureBox1.Image = LiveTimer.Properties.Resources.usb_port_1;
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