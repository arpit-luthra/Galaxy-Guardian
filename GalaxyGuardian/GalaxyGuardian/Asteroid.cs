using GalaxyGuardian.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalaxyGuardian
{
    class Asteroid : PictureBox
    {
        // Member variables
        private double mSpeed;
        private double mYPosition;

        // Constructors
        public Asteroid(int startX, int size, double speed)
        {
            // Initialize the asteroid
            this.Left = startX;
            this.Top = -size;
            this.Width = size;
            this.Height = size;
            this.mSpeed = speed;
            this.Image = Resources.Asteroid;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Visible = true;

            mYPosition = this.Top;
        }

        // Property for speed
        public double Speed
        {
            get { return mSpeed; }
            set { mSpeed = value; }
        }

        // Method to update the asteroid's position
        public void MoveTick()
        {
            // Move the asteroid downward based on its speed
            mYPosition += mSpeed;
            this.Top = (int)mYPosition;
        }

       
    }
}