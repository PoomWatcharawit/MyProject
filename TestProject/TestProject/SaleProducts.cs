using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class SaleProducts : Form
    {
        Sale sales = new Sale();
        Product product = new Product();
        Customer customer = new Customer();
        public SaleProducts()
        {
            InitializeComponent();
        }

        private void MenuCustomer_Click(object sender, EventArgs e)
        {
            Customers customerForm = new Customers();
            customerForm.Show();
            this.Hide();
        }

        private void MenuStore_Click(object sender, EventArgs e)
        {
            Store storeForm = new Store();
            storeForm.Show();
            this.Hide();
        }

        private void SaleProducts_Load(object sender, EventArgs e)
        {

            DataGridView();
            LoadCustomer();
            LoadProduct();
        }

        private void DataGridView()
        {
            StoresDBEntities StoreDB = new StoresDBEntities();
            dataGridView1.DataSource = StoreDB.Sales.ToList<Sale>();
        }

        private void ResetText()
        {
            cusIDbox.Text = "";
            proIDbox.Text = "";
            Quantitytext.Clear();
            Totaltext.Clear();
            dateTimePicker1.Text = "";
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            ResetText();
        }

        private void LoadCustomer()
        {
            StoresDBEntities StoreDB = new StoresDBEntities();
            try
            {
                var customers = StoreDB.Customers.Select(x => new { x.CustomerID, x.CustomerName }).ToList();

                while (customers.Count > 0)
                {
                    cusIDbox.DataSource = customers;
                    cusIDbox.ValueMember = "CustomerID";
                    cusIDbox.DisplayMember = "CustomerName";
                    break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CusIDbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cusIDbox.SelectedValue != null)
            {
                StoresDBEntities StoreDB = new StoresDBEntities();
                try
                {
                    int selectedCustomerID = (int)cusIDbox.SelectedValue;
                    var customer = StoreDB.Customers.FirstOrDefault(x => x.CustomerID == selectedCustomerID);

                    if (customer != null)
                    {
                        cusIDbox.Text = customer.CustomerName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadProduct()
        {
            StoresDBEntities StoreDB = new StoresDBEntities();
            try
            {
                var products = StoreDB.Products.Select(x => new { x.ProductID, x.ProductName, x.Quantity, x.Price }).ToList();

                foreach (var data in products)
                {
                    proIDbox.DataSource = products;
                    proIDbox.ValueMember = "ProductID";
                    proIDbox.DisplayMember = "ProductName";
                    Totaltext.Text = (data.Price * data.Quantity).ToString();
                    break;
                }

                proIDbox.ValueMember = "ProductID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void proIDbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (proIDbox.SelectedValue != null)
            {
                StoresDBEntities StoreDB = new StoresDBEntities();
                try
                {
                    int selectedProductID = (int)proIDbox.SelectedValue;
                    var DataPro = StoreDB.Products.FirstOrDefault(x => x.ProductID == selectedProductID);

                    if (DataPro != null)
                    {
                        proIDbox.Text = DataPro.ProductName;
                        Totaltext.Text = (DataPro.Price * DataPro.Quantity).ToString();
                        dateTimePicker1.Text = DataPro.StockIn.ToString("yyyy-MM-dd");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ProIDbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            StoresDBEntities StoreDB = new StoresDBEntities();
            try
            {
                if (cusIDbox.Text == "" || proIDbox.Text == "" || Quantitytext.Text == "")
                {
                    MessageBox.Show("Please fill all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int quantitySold;
                if (!int.TryParse(Quantitytext.Text, out quantitySold) || quantitySold <= 0)
                {
                    MessageBox.Show("Enter a valid quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedProduct = StoreDB.Products.FirstOrDefault(p => p.ProductName == proIDbox.Text);
                if (selectedProduct == null)
                {
                    MessageBox.Show("Selected product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int availableQuantity = selectedProduct.Quantity;
                if (quantitySold > availableQuantity)
                {
                    MessageBox.Show("Insufficient stock for the selected product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal totalPrice = selectedProduct.Price * quantitySold;
                sales.CustomerID = (int)cusIDbox.SelectedValue;
                sales.CustomerName = cusIDbox.Text;
                sales.ProductID = (int)proIDbox.SelectedValue;
                sales.ProductName = proIDbox.Text;
                sales.StockOut = dateTimePicker1.Value;

                sales.Quantity = int.Parse(Quantitytext.Text);
                sales.TotalPrice = decimal.Parse(Totaltext.Text);
                StoreDB.Sales.Add(sales);
                StoreDB.Products.FirstOrDefault(p => p.ProductID == sales.ProductID).Quantity -= quantitySold;
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            sales.SaleID = (int)dataGridView1.CurrentRow.Cells["SaleID"].Value;
            using (StoresDBEntities db = new StoresDBEntities())
            {
                sales = db.Sales.Where(x => x.SaleID == sales.SaleID).FirstOrDefault();
                if (sales != null)
                {
                    cusIDbox.DataSource = db.Customers.ToList();
                    proIDbox.DataSource = db.Products.ToList();
                    Quantitytext.Text = product.Quantity.ToString();
                    Totaltext.Text = sales.TotalPrice.ToString();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Quantitytext_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Quantitytext.Text, out int quantity) && decimal.TryParse(Totaltext.Text, out decimal price))
            {
                decimal total = decimal.Parse(Totaltext.Text) * quantity;
                Totaltext.Text = total.ToString("0.00");
            }
            else
            {
                Totaltext.Text = "0.00";
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            StoresDBEntities StoreDB = new StoresDBEntities();
            try
            {
                sales.CustomerID = Convert.ToInt32(cusIDbox.SelectedValue);
                sales.CustomerName = cusIDbox.Text;
                sales.ProductID = Convert.ToInt32(proIDbox.SelectedValue);
                sales.ProductName = proIDbox.Text;
                sales.Quantity = Convert.ToInt32(Quantitytext.Text);
                sales.TotalPrice = Convert.ToDecimal(Totaltext.Text);
                sales.StockOut = dateTimePicker1.Value;

                var updateSale = StoreDB.Sales.Where(x => x.SaleID == sales.SaleID).FirstOrDefault();
                if (updateSale != null)
                {
                    updateSale.CustomerID = sales.CustomerID;
                    updateSale.CustomerName = sales.CustomerName;
                    updateSale.ProductID = sales.ProductID;
                    updateSale.ProductName = sales.ProductName;
                    updateSale.Quantity = sales.Quantity;
                    updateSale.TotalPrice = (sales.Quantity * sales.TotalPrice);
                    updateSale.StockOut = sales.StockOut;
                    StoreDB.SaveChanges();
                    MessageBox.Show("Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetText();
                    DataGridView();
                }
                else
                {
                    MessageBox.Show("Sale not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var saleToDelete = StoreDB.Sales.FirstOrDefault(s => s.SaleID == sales.SaleID);
                    if (saleToDelete != null)
                    {
                        StoreDB.Sales.Remove(saleToDelete);
                        StoreDB.SaveChanges();
                        MessageBox.Show("Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetText();
                        DataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Sale not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuCustomer_Click_1(object sender, EventArgs e)
        {
            Customers customerForm = new Customers();
            customerForm.Show();
            this.Hide();
        }

    }
}
