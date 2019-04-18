using NorthwindEF.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindEF
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
           comboBox1.DataSource= CategoryBLL.GetCategory();
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";

            comboBox2.DataSource = SupplierBLL.GetSupplier();
            comboBox2.DisplayMember = "CompanyName";
            comboBox2.ValueMember = "SupplierID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductBLL.AddProduct(textBox1.Text, (int)comboBox1.SelectedValue, (int)comboBox2.SelectedValue);
        }
    }
}
