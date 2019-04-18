using NorthwindEF.BLL;
using NorthwindEF.DAL;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomerBLL.GetCustomers();
            
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm frm = new EmployeeForm();
            frm.ShowDialog();

        }

        private void shippersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShipperForm frm = new ShipperForm();
            frm.ShowDialog();

        }

        private void productsLİstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm frm = new ProductForm();
            frm.ShowDialog();
        }

        private void personelResimleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeePictureForm frm = new EmployeePictureForm();
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomerBLL.SearchCustomers(textBox1.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersForm frm = new OrdersForm();
            frm.CustomerID = this.dataGridView1.SelectedRows[0].Cells["CustomerID"].Value.ToString();
            
            frm.ShowDialog();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrderForm frm = new AddOrderForm();
            frm.CustomerID = this.dataGridView1.SelectedRows[0].Cells["CustomerID"].Value.ToString();
            frm.ShowDialog();
        }
    }
}
