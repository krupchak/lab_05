using System;
using System.Collections.Generic;

namespace p5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pizza> pizza = new List<Pizza>();

            Console.Write("Pizza ");
            string name = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            pizza.Add(new Pizza(name, n));

            List<Dough> doughs = new List<Dough>();

            Console.Write("Dough ");
            var input_d = Console.ReadLine().Split(" ");

            string flour = input_d[0];
            string baking_technique = input_d[1];
            int weight_d = int.Parse(input_d[2]);

            doughs.Add(new Dough(flour, baking_technique, weight_d));

            List<Topping> toppings = new List<Topping>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Topping ");
                var input_t = Console.ReadLine().Split(" ");

                string topping_types = input_t[0];
                int weight_t = int.Parse(input_t[1]);

                toppings.Add(new Topping(topping_types, weight_t));
            }

            foreach (var p in pizza)
            {
                p.Validate();
                foreach(var d in doughs)
                {
                    d.Validate_d();
                    Console.WriteLine(d.Calorie_counting_d());
                }
                foreach(var t in toppings)
                {
                    t.Validate_t();
                    Console.WriteLine(t.Calorie_counting_t());
                }
            }
        }
    }
}
