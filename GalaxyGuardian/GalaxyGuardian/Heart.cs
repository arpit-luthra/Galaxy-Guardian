using GalaxyGuardian.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalaxyGuardian
{
    class Heart : PictureBox
    {
        private double mSpeed;
        private double mYPosition;

        public Heart(int startX, int size, double speed)
        {
            this.Left = startX;
            this.Top = -size;
            this.Width = size;
            this.Height = size;
            this.mSpeed = speed;
            this.Image = Resources.Heart; // Ensure "Heart" is added to Resources
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

