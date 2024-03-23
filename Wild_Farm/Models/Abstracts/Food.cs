using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Models.Abstracts
{
    public abstract class Food
    {
        private int qty;

        public Food(int qty)
        {
            this.Qty = qty;
        }

        public int Qty { get { return this.qty; } set { this.qty = value; } }
    }
}
