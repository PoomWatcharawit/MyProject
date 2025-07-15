using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Customers: Form
    {
        Customer customer = new Customer();
        public Customers()
        {
            InitializeComponent();
        }

        private void MenuStore_Click(object sender, EventArgs e)
        {
            Store storeForm = new Store();
            storeForm.Show();
            this.Hide();
        }

        private void MenuSales_Click(object sender, EventArgs e)
        {
            SaleProducts saleProducts = new SaleProducts();
            saleProducts.Show();
            this.Hide();
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            StoresDBEntities StoreDB = new StoresDBEntities();
            try 
            {
                customer.CustomerName = Cusnametext.Text;
                customer.Phone = Phonetext.Text;

                StoreDB.Customers.Add(customer);
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
                customer.CustomerName = Cusnametext.Text;
                customer.Phone = Phonetext.Text;
                var updateCustomer = StoreDB.Customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
                if (updateCustomer != null)
                {
                    updateCustomer.CustomerName = customer.CustomerName;
                    updateCustomer.Phone = customer.Phone;
                    StoreDB.SaveChanges();
                    MessageBox.Show("Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetText();
                    DataGridView();
                }
                else
                {
                    MessageBox.Show("Customer not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DialogResult confirm = MessageBox.Show("you want to delete this customer?", "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                if (confirm == DialogResult.Yes) 
                {
                    var deleteCustomer = StoreDB.Customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
                    if (deleteCustomer != null)
                    {
                        StoreDB.Customers.Remove(deleteCustomer);
                        StoreDB.SaveChanges();
                        MessageBox.Show("Delete Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetText();
                        DataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Customer not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            DataGridView();
        }

        private void DataGridView()
        {
            StoresDBEntities db = new StoresDBEntities();
            dataGridView1.DataSource = db.Customers.ToList<Customer>();
        }

        private void ResetText()
        {
            Cusnametext.Clear();
            Phonetext.Clear();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            ResetText();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1) 
            {
                customer.CustomerID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CustomerID"].Value);
                using (StoresDBEntities db = new StoresDBEntities()) 
                {
                    customer = db.Customers.Where(c => c.CustomerID == customer.CustomerID).FirstOrDefault();
                    if (customer != null)
                    {
                        Cusnametext.Text = customer.CustomerName;
                        Phonetext.Text = customer.Phone;
                    }
                }
            }
        }
    }
}
