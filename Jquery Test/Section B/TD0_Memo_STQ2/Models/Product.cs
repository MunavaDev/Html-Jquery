using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STQ2.Models
{
    public class Product
    {
        public string Description;
        public double Price;

        public Product(string _Description, double _Price)
        {
            this.Description = _Description;
            this.Price = _Price;
        }
    }
}