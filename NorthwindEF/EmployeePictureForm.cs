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
    public partial class EmployeePictureForm : Form
    {
        public EmployeePictureForm()
        {
            InitializeComponent();
        }

        private void EmployeePictureForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EmployeeBLL.GetEmployeesPicture();
        }


    }
}
