using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ClBall : PictureBox
    {
        private double vx = 2;
        private double vy = 2;

        public double Vx
        {
            get
            {
                return vx;
            }
            set
            {
                vx = value;
            }
        }
        public double Vy
        {
            get
            {
                return vy;
            }
            set
            {
                vy = value;
            }
        }
    }

}
