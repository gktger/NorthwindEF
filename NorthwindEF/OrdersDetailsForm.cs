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
    public partial class OrdersDetailsForm : Form
    {
        public OrdersDetailsForm()
        {
            InitializeComponent();
        }

        public int OrderID;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void OrdersDetailsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OrderDetailBLL.GetOrder_Details(OrderID);
        }
    }
}
