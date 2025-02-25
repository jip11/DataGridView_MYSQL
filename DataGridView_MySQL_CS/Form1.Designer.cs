namespace DataGridView_MySQL_CS
{
    partial class Form1
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.IdField = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.QuantityField = new System.Windows.Forms.TextBox();
            this.PriceField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CategoryField = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.PageForwardBtn = new System.Windows.Forms.Button();
            this.PageBackBtn = new System.Windows.Forms.Button();
            this.EndBtn = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(365, 12);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(498, 272);
            this.dgvProducts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // IdField
            // 
            this.IdField.Location = new System.Drawing.Point(124, 56);
            this.IdField.Name = "IdField";
            this.IdField.Size = new System.Drawing.Size(85, 20);
            this.IdField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(124, 98);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(167, 20);
            this.NameField.TabIndex = 4;
            // 
            // QuantityField
            // 
            this.QuantityField.Location = new System.Drawing.Point(125, 167);
            this.QuantityField.Name = "QuantityField";
            this.QuantityField.Size = new System.Drawing.Size(167, 20);
            this.QuantityField.TabIndex = 6;
            // 
            // PriceField
            // 
            this.PriceField.Location = new System.Drawing.Point(124, 207);
            this.PriceField.Name = "PriceField";
            this.PriceField.Size = new System.Drawing.Size(167, 20);
            this.PriceField.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(216, 56);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 20);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CategoryField
            // 
            this.CategoryField.FormattingEnabled = true;
            this.CategoryField.Items.AddRange(new object[] {
            "Háztartási eszközök",
            "Könyvek",
            "Elektronika",
            "Egyéb"});
            this.CategoryField.Location = new System.Drawing.Point(124, 132);
            this.CategoryField.Name = "CategoryField";
            this.CategoryField.Size = new System.Drawing.Size(167, 21);
            this.CategoryField.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label6.Location = new System.Drawing.Point(1, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = "Products Manager";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(819, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Product";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(537, 343);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 18;
            this.StartBtn.Text = "<<";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // PageForwardBtn
            // 
            this.PageForwardBtn.Location = new System.Drawing.Point(702, 343);
            this.PageForwardBtn.Name = "PageForwardBtn";
            this.PageForwardBtn.Size = new System.Drawing.Size(75, 23);
            this.PageForwardBtn.TabIndex = 19;
            this.PageForwardBtn.Text = ">";
            this.PageForwardBtn.UseVisualStyleBackColor = true;
            this.PageForwardBtn.Click += new System.EventHandler(this.PageForwardBtn_Click);
            // 
            // PageBackBtn
            // 
            this.PageBackBtn.Location = new System.Drawing.Point(618, 343);
            this.PageBackBtn.Name = "PageBackBtn";
            this.PageBackBtn.Size = new System.Drawing.Size(75, 23);
            this.PageBackBtn.TabIndex = 20;
            this.PageBackBtn.Text = "<";
            this.PageBackBtn.UseVisualStyleBackColor = true;
            this.PageBackBtn.Click += new System.EventHandler(this.PageBackBtn_Click);
            // 
            // EndBtn
            // 
            this.EndBtn.Location = new System.Drawing.Point(783, 343);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(75, 23);
            this.EndBtn.TabIndex = 21;
            this.EndBtn.Text = ">>";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(217, 311);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 22;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(100, 310);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 23;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(365, 290);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 24;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 378);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EndBtn);
            this.Controls.Add(this.PageBackBtn);
            this.Controls.Add(this.PageForwardBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CategoryField);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriceField);
            this.Controls.Add(this.QuantityField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProducts);
            this.Name = "Form1";
            this.Text = "Product Manager.co";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown IdField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox QuantityField;
        private System.Windows.Forms.TextBox PriceField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox CategoryField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button PageForwardBtn;
        private System.Windows.Forms.Button PageBackBtn;
        private System.Windows.Forms.Button EndBtn;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button ResetButton;
    }
}

