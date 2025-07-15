namespace TestProject
{
    partial class Store
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MenuSales = new System.Windows.Forms.ToolStripTextBox();
            this.MenuCategory = new System.Windows.Forms.ToolStripTextBox();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Productnametext = new System.Windows.Forms.TextBox();
            this.Quantitytext = new System.Windows.Forms.TextBox();
            this.Pricetext = new System.Windows.Forms.TextBox();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.ProductCateBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MenuCustomer = new System.Windows.Forms.ToolStripTextBox();
            this.ProductIDtext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(624, 521);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCustomer,
            this.MenuCategory,
            this.MenuSales});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(994, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MenuSales
            // 
            this.MenuSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuSales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSales.Name = "MenuSales";
            this.MenuSales.Size = new System.Drawing.Size(100, 31);
            this.MenuSales.Text = "Sales";
            this.MenuSales.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MenuSales.Click += new System.EventHandler(this.MenuSales_Click);
            // 
            // MenuCategory
            // 
            this.MenuCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCategory.Name = "MenuCategory";
            this.MenuCategory.Size = new System.Drawing.Size(100, 31);
            this.MenuCategory.Text = "Category";
            this.MenuCategory.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MenuCategory.Click += new System.EventHandler(this.MenuCategory_Click);
            // 
            // Insertbtn
            // 
            this.Insertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Insertbtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.Insertbtn.Location = new System.Drawing.Point(31, 386);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(96, 46);
            this.Insertbtn.TabIndex = 2;
            this.Insertbtn.Text = "Insert";
            this.Insertbtn.UseVisualStyleBackColor = true;
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Updatebtn.ForeColor = System.Drawing.Color.Goldenrod;
            this.Updatebtn.Location = new System.Drawing.Point(133, 386);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(96, 46);
            this.Updatebtn.TabIndex = 3;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Deletebtn.ForeColor = System.Drawing.Color.Red;
            this.Deletebtn.Location = new System.Drawing.Point(235, 386);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(96, 46);
            this.Deletebtn.TabIndex = 4;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(82, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(59, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(64, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(87, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price :";
            // 
            // Productnametext
            // 
            this.Productnametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Productnametext.Location = new System.Drawing.Point(150, 178);
            this.Productnametext.Name = "Productnametext";
            this.Productnametext.Size = new System.Drawing.Size(166, 24);
            this.Productnametext.TabIndex = 11;
            this.Productnametext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Productnametext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Quantitytext
            // 
            this.Quantitytext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Quantitytext.Location = new System.Drawing.Point(150, 281);
            this.Quantitytext.Name = "Quantitytext";
            this.Quantitytext.Size = new System.Drawing.Size(166, 24);
            this.Quantitytext.TabIndex = 13;
            this.Quantitytext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantitytext.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Pricetext
            // 
            this.Pricetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Pricetext.Location = new System.Drawing.Point(150, 333);
            this.Pricetext.Name = "Pricetext";
            this.Pricetext.Size = new System.Drawing.Size(166, 24);
            this.Pricetext.TabIndex = 14;
            this.Pricetext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pricetext.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Clearbtn.Location = new System.Drawing.Point(31, 452);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(300, 42);
            this.Clearbtn.TabIndex = 17;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            // 
            // ProductCateBox
            // 
            this.ProductCateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ProductCateBox.FormattingEnabled = true;
            this.ProductCateBox.Location = new System.Drawing.Point(150, 233);
            this.ProductCateBox.Name = "ProductCateBox";
            this.ProductCateBox.Size = new System.Drawing.Size(166, 26);
            this.ProductCateBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(110, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Product";
            // 
            // MenuCustomer
            // 
            this.MenuCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCustomer.Name = "MenuCustomer";
            this.MenuCustomer.Size = new System.Drawing.Size(100, 31);
            this.MenuCustomer.Text = "Customer";
            this.MenuCustomer.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MenuCustomer.Click += new System.EventHandler(this.MenuCustomer_Click);
            // 
            // ProductIDtext
            // 
            this.ProductIDtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ProductIDtext.Location = new System.Drawing.Point(150, 130);
            this.ProductIDtext.Name = "ProductIDtext";
            this.ProductIDtext.Size = new System.Drawing.Size(166, 24);
            this.ProductIDtext.TabIndex = 21;
            this.ProductIDtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(52, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "ProductID :";
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 578);
            this.Controls.Add(this.ProductIDtext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductCateBox);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Pricetext);
            this.Controls.Add(this.Quantitytext);
            this.Controls.Add(this.Productnametext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Store";
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripTextBox MenuSales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Productnametext;
        private System.Windows.Forms.TextBox Quantitytext;
        private System.Windows.Forms.TextBox Pricetext;
        private System.Windows.Forms.ToolStripTextBox MenuCategory;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.ComboBox ProductCateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripTextBox MenuCustomer;
        private System.Windows.Forms.TextBox ProductIDtext;
        private System.Windows.Forms.Label label6;
    }
}