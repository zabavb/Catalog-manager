namespace Sixth_lesson_csh_wf
{
    partial class FormCatalogOfGoods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClearList = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.listBoxGoods = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonClearList
            // 
            this.buttonClearList.BackColor = System.Drawing.Color.Silver;
            this.buttonClearList.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearList.Location = new System.Drawing.Point(-9, 516);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(450, 40);
            this.buttonClearList.TabIndex = 0;
            this.buttonClearList.Text = "Clear list";
            this.buttonClearList.UseVisualStyleBackColor = false;
            this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.BackColor = System.Drawing.Color.Silver;
            this.buttonDeleteProduct.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteProduct.Location = new System.Drawing.Point(-9, 479);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(450, 40);
            this.buttonDeleteProduct.TabIndex = 1;
            this.buttonDeleteProduct.Text = "Delete product";
            this.buttonDeleteProduct.UseVisualStyleBackColor = false;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.BackColor = System.Drawing.Color.Silver;
            this.buttonEditProduct.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditProduct.Location = new System.Drawing.Point(-9, 442);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(450, 40);
            this.buttonEditProduct.TabIndex = 2;
            this.buttonEditProduct.Text = "Edit product";
            this.buttonEditProduct.UseVisualStyleBackColor = false;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.Silver;
            this.buttonAddProduct.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddProduct.Location = new System.Drawing.Point(-9, 405);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(450, 40);
            this.buttonAddProduct.TabIndex = 3;
            this.buttonAddProduct.Text = "Add product";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // listBoxGoods
            // 
            this.listBoxGoods.BackColor = System.Drawing.Color.Gainsboro;
            this.listBoxGoods.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxGoods.FormattingEnabled = true;
            this.listBoxGoods.ItemHeight = 22;
            this.listBoxGoods.Location = new System.Drawing.Point(0, 0);
            this.listBoxGoods.Name = "listBoxGoods";
            this.listBoxGoods.Size = new System.Drawing.Size(430, 400);
            this.listBoxGoods.TabIndex = 5;
            // 
            // FormCatalogOfGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(432, 553);
            this.Controls.Add(this.listBoxGoods);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.buttonEditProduct);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.buttonClearList);
            this.Name = "FormCatalogOfGoods";
            this.Text = "Gatalog of goods";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCatalogOfGoods_FormClosing);
            this.LocationChanged += new System.EventHandler(this.FormCatalogOfGoods_LocationChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.ListBox listBoxGoods;
    }
}

