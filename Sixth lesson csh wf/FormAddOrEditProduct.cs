using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sixth_lesson_csh_wf
{
    public partial class FormAddOrEditProduct : Form
    {
        public FormAddOrEditProduct()
        {
            InitializeComponent();
            FormCatalogOfGoods formCatalogOfGoods = new FormCatalogOfGoods();
        }

        Product product = new Product();
        bool cancel = false;

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            product.Name = textBoxName.Text;
        }
        private void textBoxCountryOfManufacture_TextChanged(object sender, EventArgs e)
        {
            product.COM = textBoxCountryOfManufacture.Text;
        }
        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPrice.Text))
                product.Price = Convert.ToSingle(textBoxPrice.Text);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxCountryOfManufacture.Text) && !string.IsNullOrEmpty(textBoxPrice.Text))
                Close();
            else
                MessageBox.Show("Please fill in all fields!", "Not all fields are filled", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            Close();
        }

        public Product Data()
        {
            /*if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxCountryOfManufacture.Text) && !string.IsNullOrEmpty(textBoxPrice.Text) && !cancel)*/
            if (!cancel)
                return product;
            else
            {
                Product productElse = new Product();
                return productElse;
            }
        }
    }
}
