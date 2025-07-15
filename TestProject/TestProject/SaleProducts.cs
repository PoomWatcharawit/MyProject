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
    public partial class SaleProducts: Form
    {
        public SaleProducts()
        {
            InitializeComponent();
        }

        private void MenuCategory_Click(object sender, EventArgs e)
        {
            CategoryProduct salesForm = new CategoryProduct();
            salesForm.Show();
            this.Hide();
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
    }
}
