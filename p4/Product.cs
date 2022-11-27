using System;
using System.Collections.Generic;
using System.Text;

namespace p4
{
    internal class Product
    {
        private string name;
        private int cost;

        public Product(string name, int cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Cost
        {
            get
            {
                return this.cost;
            }
            set
            {
                this.cost = value;
            }
        }
    }
}
