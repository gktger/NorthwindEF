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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        public string CustomerID;

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OrderBLL.GetOrders(CustomerID);
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersDetailsForm frm = new OrdersDetailsForm();
            frm.OrderID = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells["OrderID"].Value.ToString());
            frm.ShowDialog();
        }
    }
}
