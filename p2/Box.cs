using System;
using System.Collections.Generic;
using System.Text;

namespace p2
{
    internal class Box
    {
        private float length;
        private float width;
        private float height;

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

        public void Output()
        {
            if (this.Length <= 0)
            {
                Console.WriteLine("Length cannot be zero or negative.");
            }
            else if (this.Width <= 0)
            {
                Console.WriteLine("Width cannot be zero or negative.");
            }
            else if (this.Height <= 0)
            {
                Console.WriteLine("Height cannot be zero or negative.");
            }
            else
            {
                Console.WriteLine($"Surface Area - {2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * width * this.Height}" +
                    $"\nLateral Surface Area - {2 * length * this.Height + 2 * this.Width * this.Height}" +
                    $"\nVolume - {this.Length * this.Width * this.Height}");
            }
        }
    }
}
