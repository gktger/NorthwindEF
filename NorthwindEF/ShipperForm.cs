﻿using NorthwindEF.BLL;
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
    public partial class ShipperForm : Form
    {
        public ShipperForm()
        {
            InitializeComponent();
        }

        private void FormShippers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ShipperBLL.GetShippers();
        }
    }
}
