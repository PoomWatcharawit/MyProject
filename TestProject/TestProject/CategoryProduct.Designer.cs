namespace TestProject
{
    partial class CategoryProduct
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
            this.CateID = new System.Windows.Forms.Label();
            this.Catename = new System.Windows.Forms.Label();
            this.CateIDtext = new System.Windows.Forms.TextBox();
            this.Catenametext = new System.Windows.Forms.TextBox();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MenuStore = new System.Windows.Forms.ToolStripTextBox();
            this.MenuCustomer = new System.Windows.Forms.ToolStripTextBox();
            this.MenuSales = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // CateID
            // 
            this.CateID.AutoSize = true;
            this.CateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CateID.Location = new System.Drawing.Point(60, 62);
            this.CateID.Name = "CateID";
            this.CateID.Size = new System.Drawing.Size(115, 20);
            this.CateID.TabIndex = 1;
            this.CateID.Text = "CategoryID :";
            // 
            // Catename
            // 
            this.Catename.AutoSize = true;
            this.Catename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Catename.Location = new System.Drawing.Point(361, 62);
            this.Catename.Name = "Catename";
            this.Catename.Size = new System.Drawing.Size(144, 20);
            this.Catename.TabIndex = 2;
            this.Catename.Text = "CategoryName :";
            // 
            // CateIDtext
            // 
            this.CateIDtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CateIDtext.Location = new System.Drawing.Point(189, 59);
            this.CateIDtext.Name = "CateIDtext";
            this.CateIDtext.Size = new System.Drawing.Size(147, 24);
            this.CateIDtext.TabIndex = 3;
            this.CateIDtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Catenametext
            // 
            this.Catenametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Catenametext.Location = new System.Drawing.Point(525, 59);
            this.Catenametext.Name = "Catenametext";
            this.Catenametext.Size = new System.Drawing.Size(155, 24);
            this.Catenametext.TabIndex = 4;
            this.Catenametext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Clearbtn
            // 
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Clearbtn.Location = new System.Drawing.Point(483, 113);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(93, 46);
            this.Clearbtn.TabIndex = 21;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Deletebtn.ForeColor = System.Drawing.Color.Red;
            this.Deletebtn.Location = new System.Drawing.Point(381, 113);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(96, 46);
            this.Deletebtn.TabIndex = 20;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Updatebtn.ForeColor = System.Drawing.Color.Goldenrod;
            this.Updatebtn.Location = new System.Drawing.Point(279, 113);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(96, 46);
            this.Updatebtn.TabIndex = 19;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            // 
            // Insertbtn
            // 
            this.Insertbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Insertbtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.Insertbtn.Location = new System.Drawing.Point(177, 113);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(96, 46);
            this.Insertbtn.TabIndex = 18;
            this.Insertbtn.Text = "Insert";
            this.Insertbtn.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStore,
            this.MenuCustomer,
            this.MenuSales});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(762, 27);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MenuStore
            // 
            this.MenuStore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuStore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStore.Name = "MenuStore";
            this.MenuStore.Size = new System.Drawing.Size(100, 27);
            this.MenuStore.Text = "Store";
            this.MenuStore.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MenuStore.Click += new System.EventHandler(this.MenuStore_Click);
            // 
            // MenuCustomer
            // 
            this.MenuCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCustomer.Name = "MenuCustomer";
            this.MenuCustomer.Size = new System.Drawing.Size(100, 27);
            this.MenuCustomer.Text = "Customer";
            this.MenuCustomer.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MenuCustomer.Click += new System.EventHandler(this.MenuCustomer_Click);
            // 
            // MenuSales
            // 
            this.MenuSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuSales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSales.Name = "MenuSales";
            this.MenuSales.Size = new System.Drawing.Size(100, 27);
            this.MenuSales.Text = "Sales";
            this.MenuSales.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MenuSales.Click += new System.EventHandler(this.MenuSales_Click);
            // 
            // CategoryProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 522);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.Catenametext);
            this.Controls.Add(this.CateIDtext);
            this.Controls.Add(this.Catename);
            this.Controls.Add(this.CateID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CategoryProduct";
            this.Text = "CategoryProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label CateID;
        private System.Windows.Forms.Label Catename;
        private System.Windows.Forms.TextBox CateIDtext;
        private System.Windows.Forms.TextBox Catenametext;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox MenuStore;
        private System.Windows.Forms.ToolStripTextBox MenuCustomer;
        private System.Windows.Forms.ToolStripTextBox MenuSales;
    }
}