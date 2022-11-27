using System;
using System.Collections.Generic;
using System.Text;

namespace p5
{
    internal class Topping
    {
        private string topping_types;
        private double weight;

        public Topping(string topping_types, int weight)
        {
            this.Topping_types = topping_types;
            this.Weight = weight;
        }

        public string Topping_types { get; set; }
        public double Weight { get; set; }

        public void Validate_t()
        {
            if (this.Topping_types != "Meat" && this.Topping_types != "Veggies" && this.Topping_types != "Cheese" && this.Topping_types != "Sauce")
            {
                Console.WriteLine($"Cannot place {this.Topping_types} on top of your pizza.");
                Environment.Exit(0);
            }
            else if (this.Weight < 1 || this.Weight > 50)
            {
                Console.WriteLine($"{this.Topping_types} weight should be in the range [1..50].");
                Environment.Exit(0);
            }
        }

        public double Calorie_counting_t()
        {
            if (this.Topping_types == "Meat")
            {
                return 2 * this.Weight * 1.2;
            }
            else if (this.Topping_types == "Veggies")
            {
                return 2 * this.Weight * 0.8;
            }
            else if(this.Topping_types == "Cheese")
            {
                return 2 * this.Weight * 1.1;
            }
            else
            {
                return 2 * this.Weight * 0.9;
            }
        }
    }
}
