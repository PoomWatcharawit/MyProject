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

        private void MenuCategory_Click_1(object sender, EventArgs e)
        {
            CategoryProduct salesForm = new CategoryProduct();
            salesForm.Show();
            this.Hide();
        }

        private void MenuSales_Click(object sender, EventArgs e)
        {
            SaleProducts saleProducts = new SaleProducts();
            saleProducts.Show();
            this.Hide();
        }
    }
}
