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
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductBLL.GetProducts();

            comboBox1.DataSource = ShipperBLL.GetShippers();
            comboBox1.DisplayMember = "CompanyName";
            comboBox1.ValueMember = "ShipperID";


        }

        public string CustomerID;
        private void btn_ekle_Click(object sender, EventArgs e)
        {

            OrderBLL.AddOrders(CustomerID, Convert.ToInt32(comboBox1.SelectedValue)); 

        }
    }
}
