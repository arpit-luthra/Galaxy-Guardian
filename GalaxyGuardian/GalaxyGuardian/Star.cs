using GalaxyGuardian.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalaxyGuardian
{
    class Star : PictureBox
    {
        private double mSpeed;
        private double mYPosition;

        public Star(int startX, int size, double speed)
        {
            this.Left = startX;
            this.Top = -size;
            this.Width = size;
            this.Height = size;
            this.mSpeed = speed;
            this.Image = Resources.ShiningStar;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Visible = true;

            mYPosition = this.Top;
        }

        public void MoveTick()
        {
            mYPosition += mSpeed;
            this.Top = (int)mYPosition;
        }

    }

}
