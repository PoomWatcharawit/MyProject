namespace TestProject
{
    partial class Customers
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
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.Cusnametext = new System.Windows.Forms.TextBox();
            this.cusIDtext = new System.Windows.Forms.TextBox();
            this.Catename = new System.Windows.Forms.Label();
            this.CateID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Phonetext = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MenuCategory = new System.Windows.Forms.ToolStripTextBox();
            this.MenuSales = new System.Windows.Forms.ToolStripTextBox();
            this.MenuStore = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clearbtn
            // 
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Clearbtn.Location = new System.Drawing.Point(529, 104);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(93, 46);
            this.Clearbtn.TabIndex = 30;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Deletebtn.ForeColor = System.Drawing.Color.Red;
            this.Deletebtn.Location = new System.Drawing.Point(427, 104);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(96, 46);
            this.Deletebtn.TabIndex = 29;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Updatebtn.ForeColor = System.Drawing.Color.Goldenrod;
            this.Updatebtn.Location = new System.Drawing.Point(325, 104);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(96, 46);
            this.Updatebtn.TabIndex = 28;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            // 
            // Insertbtn
            // 
            this.Insertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Insertbtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.Insertbtn.Location = new System.Drawing.Point(223, 104);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(96, 46);
            this.Insertbtn.TabIndex = 27;
            this.Insertbtn.Text = "Insert";
            this.Insertbtn.UseVisualStyleBackColor = true;
            // 
            // Cusnametext
            // 
            this.Cusnametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Cusnametext.Location = new System.Drawing.Point(424, 53);
            this.Cusnametext.Name = "Cusnametext";
            this.Cusnametext.Size = new System.Drawing.Size(155, 24);
            this.Cusnametext.TabIndex = 26;
            this.Cusnametext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cusIDtext
            // 
            this.cusIDtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cusIDtext.Location = new System.Drawing.Point(166, 53);
            this.cusIDtext.Name = "cusIDtext";
            this.cusIDtext.Size = new System.Drawing.Size(80, 24);
            this.cusIDtext.TabIndex = 25;
            this.cusIDtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Catename
            // 
            this.Catename.AutoSize = true;
            this.Catename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Catename.Location = new System.Drawing.Point(258, 57);
            this.Catename.Name = "Catename";
            this.Catename.Size = new System.Drawing.Size(150, 20);
            this.Catename.TabIndex = 24;
            this.Catename.Text = "CustomerName :";
            // 
            // CateID
            // 
            this.CateID.AutoSize = true;
            this.CateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CateID.Location = new System.Drawing.Point(35, 56);
            this.CateID.Name = "CateID";
            this.CateID.Size = new System.Drawing.Size(121, 20);
            this.CateID.TabIndex = 23;
            this.CateID.Text = "CustomerID :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(819, 327);
            this.dataGridView1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(594, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Phone :";
            // 
            // Phonetext
            // 
            this.Phonetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Phonetext.Location = new System.Drawing.Point(666, 53);
            this.Phonetext.MaxLength = 10;
            this.Phonetext.Name = "Phonetext";
            this.Phonetext.Size = new System.Drawing.Size(130, 24);
            this.Phonetext.TabIndex = 32;
            this.Phonetext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStore,
            this.MenuCategory,
            this.MenuSales});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(843, 27);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MenuCategory
            // 
            this.MenuCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCategory.Name = "MenuCategory";
            this.MenuCategory.Size = new System.Drawing.Size(100, 31);
            this.MenuCategory.Text = "Category";
            this.MenuCategory.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MenuCategory.Click += new System.EventHandler(this.MenuCategory_Click_1);
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
            // MenuStore
            // 
            this.MenuStore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuStore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStore.Name = "MenuStore";
            this.MenuStore.Size = new System.Drawing.Size(100, 31);
            this.MenuStore.Text = "Store";
            this.MenuStore.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MenuStore.Click += new System.EventHandler(this.MenuStore_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 513);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Phonetext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.Cusnametext);
            this.Controls.Add(this.cusIDtext);
            this.Controls.Add(this.Catename);
            this.Controls.Add(this.CateID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Customers";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.TextBox Cusnametext;
        private System.Windows.Forms.TextBox cusIDtext;
        private System.Windows.Forms.Label Catename;
        private System.Windows.Forms.Label CateID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Phonetext;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox MenuCategory;
        private System.Windows.Forms.ToolStripTextBox MenuSales;
        private System.Windows.Forms.ToolStripTextBox MenuStore;
    }
}