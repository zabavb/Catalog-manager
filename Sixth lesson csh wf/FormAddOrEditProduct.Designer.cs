namespace Sixth_lesson_csh_wf
{
    partial class FormAddOrEditProduct
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCounrtyOfManufacture = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCountryOfManufacture = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Silver;
            this.buttonOK.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(12, 291);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(119, 40);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Silver;
            this.buttonCancel.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(171, 291);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(119, 40);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(121, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 21);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCounrtyOfManufacture
            // 
            this.labelCounrtyOfManufacture.AutoSize = true;
            this.labelCounrtyOfManufacture.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCounrtyOfManufacture.Location = new System.Drawing.Point(68, 110);
            this.labelCounrtyOfManufacture.Name = "labelCounrtyOfManufacture";
            this.labelCounrtyOfManufacture.Size = new System.Drawing.Size(177, 21);
            this.labelCounrtyOfManufacture.TabIndex = 10;
            this.labelCounrtyOfManufacture.Text = "Country of manufacture";
            this.labelCounrtyOfManufacture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(128, 192);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 21);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Price";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Silver;
            this.textBoxName.Font = new System.Drawing.Font("Calibri", 13.2F);
            this.textBoxName.Location = new System.Drawing.Point(12, 63);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(278, 34);
            this.textBoxName.TabIndex = 15;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxCountryOfManufacture
            // 
            this.textBoxCountryOfManufacture.BackColor = System.Drawing.Color.Silver;
            this.textBoxCountryOfManufacture.Font = new System.Drawing.Font("Calibri", 13.2F);
            this.textBoxCountryOfManufacture.Location = new System.Drawing.Point(12, 143);
            this.textBoxCountryOfManufacture.Name = "textBoxCountryOfManufacture";
            this.textBoxCountryOfManufacture.Size = new System.Drawing.Size(278, 34);
            this.textBoxCountryOfManufacture.TabIndex = 16;
            this.textBoxCountryOfManufacture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCountryOfManufacture.TextChanged += new System.EventHandler(this.textBoxCountryOfManufacture_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.Silver;
            this.textBoxPrice.Font = new System.Drawing.Font("Calibri", 13.2F);
            this.textBoxPrice.Location = new System.Drawing.Point(12, 225);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(278, 34);
            this.textBoxPrice.TabIndex = 17;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // FormAddOrEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(302, 353);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxCountryOfManufacture);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCounrtyOfManufacture);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Name = "FormAddOrEditProduct";
            this.Text = "Add or edit product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCounrtyOfManufacture;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCountryOfManufacture;
        private System.Windows.Forms.TextBox textBoxPrice;
    }
}