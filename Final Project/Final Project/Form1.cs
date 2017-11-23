using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Fredaljohn D. Rohrbaugh
//CS/IST 292
//Final Project 3
//November 22, 2017

namespace Final_Project
{
    public partial class MainForm : Form
    {
        //Base Flavor Variables
        private double vanillaPrice = 2.99;
        private double chocolatePrice = 3.99;
        private double strawberryPrice = 4.99;
        //Base Topping Variables
        private double chocolateSaucePrice = 1.99;
        private double sprinklesPrice = .99;
        private double gummybearsPrice = 2.99;
        private double salesTax = .08;
        private double totalBeforeTax;
        private double grandTotal;

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblSalesTax.Text += " (" + salesTax.ToString("p") + "):";
            chkboxChocolate.Text += " (" + chocolatePrice.ToString("c") + ")";
            chkboxVanilla.Text += " (" + vanillaPrice.ToString("c") + ")";
            chkboxStrawberry.Text += " (" + strawberryPrice.ToString("c") + ")";
            chkboxSprinkles.Text += " (" + sprinklesPrice.ToString("c") + ")";
            chkboxGummyBears.Text += " (" + gummybearsPrice.ToString("c") + ")";
            chkboxChocolateSauce.Text += " (" + chocolateSaucePrice.ToString("c") + ")";
        }

        private void btnConfirmSale_Click(object sender, EventArgs e)
        {
            //TextBox Totals;
            double baseflavorTotal =0;
            double toppingsTotal = 0;
            double salesTaxTotal;
            //Check for base flavors
            if (chkboxVanilla.Checked)
            {
                totalBeforeTax += vanillaPrice;
                baseflavorTotal += vanillaPrice;
            }
            if (chkboxChocolate.Checked)
            {
                totalBeforeTax += chocolatePrice;
                baseflavorTotal += chocolatePrice;
            }

            if (chkboxStrawberry.Checked)
            {
                totalBeforeTax += strawberryPrice;
                baseflavorTotal += strawberryPrice;
            }
            //Check for toppings
            if (chkboxChocolateSauce.Checked)
            {
                totalBeforeTax += chocolateSaucePrice;
                toppingsTotal += chocolateSaucePrice;
            }
            if (chkboxGummyBears.Checked)
            {
                totalBeforeTax += gummybearsPrice;
                toppingsTotal += gummybearsPrice;
            }
            if (chkboxSprinkles.Checked)
            {
                totalBeforeTax += sprinklesPrice;
                toppingsTotal += sprinklesPrice;
            }

            //Calculate tax and grand total
            salesTaxTotal = totalBeforeTax * salesTax;
            grandTotal = totalBeforeTax + salesTaxTotal;

            //Display Results
            txtboxBaseFlavorTotal.Text = baseflavorTotal.ToString("c");
            txtboxToppingsTotal.Text = toppingsTotal.ToString("c");
            txtboxSalesTaxTotal.Text = salesTaxTotal.ToString("c");
            txtboxGrandTotal.Text = grandTotal.ToString("c");

        }
        


        private void chkboxVanilla_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}