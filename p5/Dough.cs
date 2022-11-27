using System;
using System.Collections.Generic;
using System.Text;

namespace p5
{
    internal class Dough
    {
        private string flour;
        private string baking_technique;
        private double weight;

        public Dough (string flour, string baking_technique, int weight)
        {
            this.Flour = flour;
            this.Baking_technique = baking_technique;
            this.Weight = weight;
        }

        public string Flour { get; set; }
        public string Baking_technique { get; set; }
        public double Weight { get; set; }

        public void Validate_d()
        {
            if (this.Flour != "White" && this.Flour != "Wholegrain" && this.Baking_technique != "Crispy" && this.Baking_technique != "Chewy" && this.Baking_technique != "Homemade")
            {
                Console.WriteLine("Invalid type of dough.");
                Environment.Exit(0);
            }
            else if(this.Weight < 1 || this.Weight > 200)
            {
                Console.WriteLine("Dough weight should be in the range [1..200].");
                Environment.Exit(0);
            }
        }

        public double Calorie_counting_d()
        {
            if (this.Flour == "White" && this.Baking_technique == "Crispy")
            {
                return 2 * this.Weight * 1.5 * 0.9;
            }
            else if (this.Flour == "White" && this.Baking_technique == "Chewy")
            {
                return 2 * this.Weight * 1.5 * 1.1;
            }
            else if (this.Flour == "White" && this.Baking_technique == "Homemade")
            {
                return 2 * this.Weight * 1.5 * 1.0;
            }
            else if (this.Flour == "Wholegrain" && this.Baking_technique == "Crispy")
            {
                return 2 * this.Weight * 1.0 * 0.9;
            }
            else if (this.Flour == "Wholegrain" && this.Baking_technique == "Chewy")
            {
                return 2 * this.Weight * 1.0 * 1.1;
            }
            else
            {
                return 2 * this.Weight * 1.0 * 1.0;
            }
        }
    }
}
