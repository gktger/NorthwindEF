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
            FormShippers frm = new FormShippers();
            frm.ShowDialog();

        }
    }
}
