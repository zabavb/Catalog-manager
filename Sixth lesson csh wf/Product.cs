using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Sixth_lesson_csh_wf
{
    public class Product
    {
        public string Name { get; set; }
        public string COM { get; set; }
        public float Price { get; set; }

        public Product() { }
        public Product(string name, string cOM, float price)
        {
            Name = name;
            COM = cOM;
            Price = price;
        }
        public override string ToString()
        {
            return $"Name: {Name} | COM: {COM} | Price: {Price}";
        }
    }
}
