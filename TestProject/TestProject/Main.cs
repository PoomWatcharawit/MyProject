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
    public partial class Main: Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ManuCalculate_Click(object sender, EventArgs e)
        {

        }

        private void ManuStore_Click(object sender, EventArgs e)
        {
            Store storeForm = new Store();
            storeForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ตรวจสอบค่าว่าง
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Number is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Num1, Num2;
            // ตรวจสอบว่าเป็นตัวเลขเท่านั้น
            if (!int.TryParse(textBox1.Text, out Num1) || !int.TryParse(textBox2.Text, out Num2))
            {
                MessageBox.Show("Please enter valid numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int result = Num1 + Num2;
            label2.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ตรวจสอบค่าว่าง
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Number is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Num1, Num2;
            // ตรวจสอบว่าเป็นตัวเลขเท่านั้น
            if (!int.TryParse(textBox1.Text, out Num1) || !int.TryParse(textBox2.Text, out Num2))
            {
                MessageBox.Show("Please enter valid numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int result = Num1 - Num2;
            label2.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // ตรวจสอบค่าว่าง
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Number is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Num1, Num2;
            // ตรวจสอบว่าเป็นตัวเลขเท่านั้น
            if (!int.TryParse(textBox1.Text, out Num1) || !int.TryParse(textBox2.Text, out Num2))
            {
                MessageBox.Show("Please enter valid numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int result = Num1 * Num2;
            label2.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ตรวจสอบค่าว่าง
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Number is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Num1, Num2;
            // ตรวจสอบว่าเป็นตัวเลขเท่านั้น
            if (!int.TryParse(textBox1.Text, out Num1) || !int.TryParse(textBox2.Text, out Num2))
            {
                MessageBox.Show("Please enter valid numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ตรวจสอบหารด้วยศูนย์
            if (Num2 == 0)
            {
                MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int result = Num1 / Num2;
            label2.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
