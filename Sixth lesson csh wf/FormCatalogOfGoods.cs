using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sixth_lesson_csh_wf
{
    public partial class FormCatalogOfGoods : Form
    {
        public FormCatalogOfGoods()
        {
            InitializeComponent();
        }

        Catalog catalog = new Catalog();

        private void FormCatalogOfGoods_LocationChanged(object sender, EventArgs e)
        {
            //Read
            const string path = "BinaryFile.bin";

            FileStream fileStreamRead1 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader binaryReader1 = new BinaryReader(fileStreamRead1);

            string tmp = "";
            if (binaryReader1.BaseStream.Position != binaryReader1.BaseStream.Length)
                tmp = binaryReader1.ReadString();

            fileStreamRead1.Close();
            binaryReader1.Close();

            FileStream fileStreamRead2 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader binaryReader2 = new BinaryReader(fileStreamRead2);

            if (tmp != "Is empty" || string.IsNullOrEmpty(tmp))
            {
                while (binaryReader2.BaseStream.Position != binaryReader2.BaseStream.Length)
                {
                    Product product = new Product();
                    product.Name = binaryReader2.ReadString();
                    product.COM = binaryReader2.ReadString();
                    product.Price = binaryReader2.ReadSingle();
                    catalog.Products.Add(product);
                }
            }

            fileStreamRead2.Close();
            binaryReader2.Close();
            
            Print();
        }

        public void Print()
        {
            listBoxGoods.Items.Clear();
            for (int i = 0; i < catalog.Products.Count; i++)
                listBoxGoods.Items.Add(catalog.Products[i].ToString());
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FormAddOrEditProduct formAddOrEditProduct = new FormAddOrEditProduct();
            formAddOrEditProduct.Text = "Add product";
            formAddOrEditProduct.ShowDialog();

            catalog.AddProduct(formAddOrEditProduct.Data());
            Print();
        }
        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (listBoxGoods.SelectedIndex != -1)
            {
                FormAddOrEditProduct formAddOrEditProduct = new FormAddOrEditProduct();
                formAddOrEditProduct.Text = "Edit product";
                formAddOrEditProduct.ShowDialog();
                catalog.EditProduct(listBoxGoods.SelectedIndex, formAddOrEditProduct.Data());
                Print();
            }
            else
                MessageBox.Show("Please select product", "Product did not select", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (listBoxGoods.SelectedIndex != -1)
            {
                catalog.DeleteProduct(listBoxGoods.SelectedIndex);
                Print();
            }
            else
                MessageBox.Show("Please select product", "Product did not select", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            catalog.Products.Clear();
            Print();
        }

        private void FormCatalogOfGoods_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Write
            const string path = "BinaryFile.bin";
            FileStream fileStreamWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter binaryWriter = new BinaryWriter(fileStreamWrite);

            if (catalog.Products.Count != 0)
            {
                for (int i = 0; i < catalog.Products.Count; i++)
                {
                    binaryWriter.Write(catalog.Products[i].Name);
                    binaryWriter.Write(catalog.Products[i].COM);
                    binaryWriter.Write(catalog.Products[i].Price);
                }
            }
            else
                binaryWriter.Write("Is empty");

            fileStreamWrite.Close();
            binaryWriter.Close();
        }
    }
}
