using System;
using System.Collections.Generic;
using System.Text;

namespace p1
{
    internal class Box
    {
        private float length;
        private float width;
        private float height;

        public Box() { }

        public Box(float length, float width, float height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public float Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
            }
        }

        public float Width
        {
            get 
            { 
                return this.width; 
            }
            set 
            { 
                this.width = value; 
            }
        }

        public float Height
        {
            get 
            { 
                return this.height; 
            }
            set 
            { 
                this.height = value; 
            }
        }

        public void SurfaceArea()
        {
            Console.WriteLine($"Surface Area - {2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * width * this.Height}");
        }

        public void LateralSurfaceArea()
        {
            Console.WriteLine($"Lateral Surface Area - {2 * this.Length * this.Height + 2 * this.Width * this.Height}");
        }

        public void Volume()
        {
            Console.WriteLine($"Volume - {this.Length * this.Width * this.Height}");
        }
    }
}
