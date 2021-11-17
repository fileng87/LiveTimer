using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveTimer
{
    class SetTime
    {
        private int h;
        public int H
        {
            get { return h; }
            set
            {
                if (value < 0)
                {
                    h = 0;
                    m = 0;
                    s = 0;
                }
                else
                {
                    h = value;
                }
            }
        }
        private int m;
        public int M
        {
            get { return m; }
            set
            {
                if (value < 0)
                {
                    m = 59;
                    H--;
                }
                else
                {
                    m = value;
                }
            }
        }
        private int s;
        public int S
        {
            get { return s; }
            set
            {
                if (value < 0)
                {
                    s = 59;
                    M--;
                }
                else
                {
                    s = value;
                }
            }
        }

        public SetTime(int h, int m, int s)
        {
            H = h;
            M = m;
            S = s;
        }
    }
}
