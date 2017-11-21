using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnViewAllSales_Click(object sender, EventArgs e)
        {
            ViewAllSalesForm viewallForm = new ViewAllSalesForm();
            viewallForm.Show();
        }

        private void btnEditSales_Click(object sender, EventArgs e)
        {
            EditSalesForm viewEditForm = new EditSalesForm();
            viewEditForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}