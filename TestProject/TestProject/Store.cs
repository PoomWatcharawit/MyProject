using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Store: Form
    {
        Product product = new Product();
        public Store()
        {
            InitializeComponent();
        }

        private void Store_Load(object sender, EventArgs e)
        {
            DataGridView();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            Customers customerForm = new Customers();
            customerForm.Show();
            this.Hide();
        }

        private void MenuSales_Click(object sender, EventArgs e)
        {
            SaleProducts salesForm = new SaleProducts();
            salesForm.Show();
            this.Hide();
        }

        private void ResetText() 
        {
            Productnametext.Clear();
            Catebox.Text = "";
            Quantitytext.Clear();
            Pricetext.Clear();
            dateTimePicker1.Text = "";
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            ResetText();
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            StoresDBEntities StoreDB = new StoresDBEntities();
            try
            {
                product.ProductName = Productnametext.Text;
                product.Category = Catebox.Text;
                product.Quantity = Convert.ToInt32(Quantitytext.Text);
                product.Price = Convert.ToDecimal(Pricetext.Text);
                product.StockIn = dateTimePicker1.Value;

                StoreDB.Products.Add(product);
                StoreDB.SaveChanges();

                MessageBox.Show("Insert Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetText();
                DataGridView(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            StoresDBEntities StoreDB = new StoresDBEntities();
            try
            {
                product.ProductName = Productnametext.Text;
                product.Category = Catebox.Text;
                product.Quantity = Convert.ToInt32(Quantitytext.Text);
                product.Price = Convert.ToDecimal(Pricetext.Text);
                var updateProduct = StoreDB.Products.Where(x => x.ProductID == product.ProductID).FirstOrDefault();
                if (updateProduct != null)
                {
                    updateProduct.ProductName = product.ProductName;
                    updateProduct.Category = product.Category;
                    updateProduct.Quantity = product.Quantity;
                    updateProduct.Price = product.Price;
                    StoreDB.SaveChanges();
                    MessageBox.Show("Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetText();
                    DataGridView();
                }
                else
                {
                    MessageBox.Show("Product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            StoresDBEntities StoreDB = new StoresDBEntities();
            try
            {
                DialogResult confirm = MessageBox.Show("you want to delete this product?", "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                if (confirm == DialogResult.Yes)
                {
                    var deleteProduct = StoreDB.Products.Where(x => x.ProductID == product.ProductID).FirstOrDefault();
                    if (deleteProduct != null)
                    {

                        StoreDB.Products.Remove(deleteProduct);
                        StoreDB.SaveChanges();
                        MessageBox.Show("Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetText();
                        DataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView()
        {
            StoresDBEntities db = new StoresDBEntities();
            dataGridView1.DataSource = db.Products.ToList<Product>();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                product.ProductID = (int)dataGridView1.CurrentRow.Cells["ProductID"].Value;
                using (StoresDBEntities db = new StoresDBEntities())
                {
                    product = db.Products.Where(x => x.ProductID == product.ProductID).FirstOrDefault();
                    if (product != null)
                    {
                        Productnametext.Text = product.ProductName;
                        Catebox.Text = product.Category;
                        Quantitytext.Text = product.Quantity.ToString();
                        Pricetext.Text = product.Price.ToString();
                    }
                }
            }
        }
    }
}
