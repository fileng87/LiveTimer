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
    }
}
