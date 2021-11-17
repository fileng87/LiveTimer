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
    public partial class FormSetTime : Form
    {
        public FormSetTime()
        {
            InitializeComponent();
        }

        private void FormSetTime_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i < 60)
                {
                    comboBox2.Items.Add(i);
                    comboBox3.Items.Add(i);
                }
                comboBox1.Items.Add(i);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
