using System;
using System.Collections.Generic;
using System.Text;

namespace Book_task
{
    internal class Product
    {
        public string Name;
        public int No;
        public int Price;
        public int count;

        public Product()
        {

        }

        public Product(string Name, int No, int Price)
        {
            this.Name = Name;
            this.No = No;
            this.Price = Price;
        }
    }
}