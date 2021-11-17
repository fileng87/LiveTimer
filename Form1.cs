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

        public Form2 fm = new Form2();

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
        }

        private void btn_startTime_Click(object sender, EventArgs e)
        {
            btnReset();
            setBtn(btn_startTime);
            lab_titel.Text = "距離開始的時間";
            openUserContral(startTime);
        }

        private void btn_endTime_Click(object sender, EventArgs e)
        {
            btnReset();
            setBtn(btn_endTime);
            lab_titel.Text = "距離結束時間";
            openUserContral(endTime);
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if(fm != null)
            {
                fm.Close();
            }
            fm = new Form2();
            fm.TopLevel = true;
            fm.Show();
        }
    }
}
