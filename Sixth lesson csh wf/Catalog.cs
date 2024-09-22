using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sixth_lesson_csh_wf
{
    public class Catalog
    {
        public List<Product> Products { get; set; }

        public Catalog()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            if (!string.IsNullOrEmpty(product.Name))
                Products.Add(product);
        }
        public void EditProduct(int index, Product product)
        {
            if (!string.IsNullOrEmpty(product.Name))
                Products[index] = product;
        }
        public void DeleteProduct(int index)
        {
            for (int i = 0; i < Products.Count; i++)
                Products.RemoveAt(index);
        }
    }
}
