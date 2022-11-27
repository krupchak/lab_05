using System;
using System.Collections.Generic;
using System.Text;

namespace p5
{
    internal class Pizza
    {
        private string name;
        private Dough dough;
        private Topping topping;

        public Pizza(string name, int n)
        {
            this.Name = name;
            this.Number_top = n;
        }

        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Topping Topping { get; set; }

        public int Number_top { get; set; }

        public void Validate()
        {
            if(this.Name.Length < 1 || this.Name.Length>15)
            {
                Console.WriteLine("Pizza name should be between 1 and 15 symbols.");
                Environment.Exit(1);
            }
            else if(this.Number_top < 0 || this.Number_top > 10)
            {
                Console.WriteLine("Number of toppings should be in range [0..10].");
            }
        }

        public double total_calories
        {
            get
            {
                return total_calories;
            }
            set
            {
                total_calories += value;
            }
        }
    }
}
