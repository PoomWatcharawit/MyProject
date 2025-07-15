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
    public partial class Store: Form
    {
        public Store()
        {
            InitializeComponent();
        }

        private void Store_Load(object sender, EventArgs e)
        {

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

        private void MenuCustomer_Click(object sender, EventArgs e)
        {
            Customers customerForm = new Customers();
            customerForm.Show();
            this.Hide();
        }

        private void MenuCategory_Click(object sender, EventArgs e)
        {
            CategoryProduct categoryForm = new CategoryProduct();
            categoryForm.Show();
            this.Hide();
        }

        private void MenuSales_Click(object sender, EventArgs e)
        {
            SaleProducts salesForm = new SaleProducts();
            salesForm.Show();
            this.Hide();
        }
    }
}
