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

            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
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

        private PrintDocument printDocument = new PrintDocument();
        private int currentRow = 0;
        private int[] columnWidth;

        private void CalculateColumnWidth()
        {
            columnWidth = new int[dataGridView1.Columns.Count];
            using (Graphics g = this.CreateGraphics())
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    // เริ่มต้นที่ความกว้างขั้นต่ำของคอลัมน์คือ 100px
                    int maxWidth = 1000; // กำหนดความกว้างขั้นต่ำ
                    maxWidth = Math.Max(maxWidth, (int)g.MeasureString(dataGridView1.Columns[i].HeaderText, new Font("Segoe", 9)).Width);

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[i].Value != null)
                        {
                            string cellText = row.Cells[i].Value.ToString();
                            int cellWidth = (int)g.MeasureString(cellText, new Font("Segoe", 9)).Width;

                            // ถ้าความกว้างของเซลล์เกินกว่าความกว้างที่ตั้งไว้ ให้ใช้ความกว้างของเซลล์
                            maxWidth = Math.Max(maxWidth, cellWidth);
                        }
                    }
                    columnWidth[i] = maxWidth;
                }
            }
        }


        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int rowHeight = 40;
            int topMargin = e.MarginBounds.Top + 60;
            int ypos = topMargin;
            Font headerFont = new Font("Segoe", 12, FontStyle.Bold);
            Font cellFont = new Font("Segoe", 9);
            Font tableheadFont = new Font("Segoe", 10, FontStyle.Bold);

            // คำนวณความกว้างของคอลัมน์ทั้งหมด
            CalculateColumnWidth();

            // คำนวณความกว้างของตาราง
            int tableWidth = columnWidth.Sum();
            int leftMargin = e.MarginBounds.Left + (e.MarginBounds.Width - tableWidth) / 2;

            // ถ้าความกว้างของตารางเกินขอบเขตของหน้ากระดาษ ให้ปรับขนาดคอลัมน์
            if (tableWidth > e.MarginBounds.Width)
            {
                float scale = e.MarginBounds.Width / (float)tableWidth;

                // ปรับขนาดความกว้างคอลัมน์ตามอัตราส่วน (scale)
                for (int i = 0; i < columnWidth.Length; i++)
                {
                    columnWidth[i] = (int)(columnWidth[i] * scale);
                }

                // คำนวณความกว้างของตารางใหม่
                tableWidth = columnWidth.Sum();
                leftMargin = e.MarginBounds.Left + (e.MarginBounds.Width - tableWidth) / 2; // ปรับ left margin เพื่อให้ตารางอยู่กลาง
            }

            // เขียนหัวเรื่อง
            string head = "Sale Products Report";
            SizeF headSize = e.Graphics.MeasureString(head, headerFont);
            float headX = e.MarginBounds.Left + (e.MarginBounds.Width - headSize.Width) / 2;
            e.Graphics.DrawString(head, headerFont, Brushes.Black, headX, e.MarginBounds.Top);

            // เขียนหัวคอลัมน์
            int x = leftMargin;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                string headerText = dataGridView1.Columns[i].HeaderText;
                Rectangle headerRect = new Rectangle(x, ypos, columnWidth[i], rowHeight);
                e.Graphics.FillRectangle(Brushes.LightGray, headerRect);
                e.Graphics.DrawRectangle(Pens.Black, headerRect);
                // จัดข้อความในหัวคอลัมน์ให้อยู่กลาง
                StringFormat headerStringFormat = new StringFormat();
                headerStringFormat.Alignment = StringAlignment.Center;
                headerStringFormat.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(headerText, tableheadFont, Brushes.Black, headerRect, headerStringFormat);
                x += columnWidth[i];
            }

            ypos += rowHeight;

            // แสดงข้อมูลในแถว
            while (currentRow < dataGridView1.RowCount)
            {
                DataGridViewRow row = dataGridView1.Rows[currentRow];
                if (!row.IsNewRow)
                {
                    x = leftMargin;
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        string cellText = row.Cells[i].Value?.ToString() ?? "";

                        if (row.Cells[i].Value is Customer customer)
                        {
                            cellText = customer.CustomerName;
                        }
                        else if (row.Cells[i].Value is Product product)
                        {
                            cellText = product.ProductName;
                        }
                        else if (row.Cells[i].Value is Sale sale)
                        {
                            cellText = sale.Quantity.ToString();
                            cellText = sale.TotalPrice.ToString("0.00");
                            cellText = sale.StockOut.ToString("yyyy-MM-dd");
                        }

                        Rectangle cellRect = new Rectangle(x, ypos, columnWidth[i], rowHeight);
                        e.Graphics.DrawRectangle(Pens.Black, cellRect);
                        e.Graphics.DrawString(cellText, cellFont, Brushes.Black, cellRect);
                        x += columnWidth[i];
                    }

                    ypos += rowHeight;

                    // ถ้าข้อมูลเกินขอบเขตของหน้ากระดาษ ให้ไปหน้าถัดไป
                    if (ypos + rowHeight > e.MarginBounds.Bottom)
                    {
                        currentRow++;
                        e.HasMorePages = true;
                        return;
                    }
                }
                currentRow++;
            }
            currentRow = 0;
            e.HasMorePages = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentRow = 0;
            CalculateColumnWidth();
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.ShowDialog();
        }
    }
}
