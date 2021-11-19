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
    public partial class UCNumberChoser : UserControl
    {
        public int Max;
        public int Min;

        public int num;
        public int Num
        {
            get { return num; }
            set
            {
                if (value > Max)
                {
                    num = Max;
                }
                else if (value < Min)
                {
                    num = Min;
                }
            }
        }

        public UCNumberChoser(int max = 99, int min = 0)
        {
            this.Max = max;
            this.Min = min;
            InitializeComponent();
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            Num--;
            txt_Num.Text = Num.ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Num++;
            txt_Num.Text = Num.ToString();
        }

        private void txt_Num_TextChanged(object sender, EventArgs e)
        {
            Num = int.Parse(txt_Num.Text);
            txt_Num.Text = Num.ToString();
        }
    }
}
