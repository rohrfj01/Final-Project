namespace Final_Project
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnViewAllSales = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConfirmSale = new System.Windows.Forms.Button();
            this.btnEditSales = new System.Windows.Forms.Button();
            this.btnEditIceCream = new System.Windows.Forms.Button();
            this.grpboxBaseFlavors = new System.Windows.Forms.GroupBox();
            this.chkboxStrawberry = new System.Windows.Forms.CheckBox();
            this.chkboxChocolate = new System.Windows.Forms.CheckBox();
            this.chkboxVanilla = new System.Windows.Forms.CheckBox();
            this.grpboxToppings = new System.Windows.Forms.GroupBox();
            this.chkboxGummyBears = new System.Windows.Forms.CheckBox();
            this.chkboxChocolateSauce = new System.Windows.Forms.CheckBox();
            this.chkboxSprinkles = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtboxBaseFlavorTotal = new System.Windows.Forms.TextBox();
            this.txtboxToppingsTotal = new System.Windows.Forms.TextBox();
            this.txtboxSalesTaxTotal = new System.Windows.Forms.TextBox();
            this.txtboxGrandTotal = new System.Windows.Forms.TextBox();
            this.lblBaseFlavor = new System.Windows.Forms.Label();
            this.lblTotalToppings = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.grpboxBaseFlavors.SuspendLayout();
            this.grpboxToppings.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewAllSales
            // 
            this.btnViewAllSales.Location = new System.Drawing.Point(246, 491);
            this.btnViewAllSales.Name = "btnViewAllSales";
            this.btnViewAllSales.Size = new System.Drawing.Size(124, 48);
            this.btnViewAllSales.TabIndex = 0;
            this.btnViewAllSales.Text = "View All Sales";
            this.btnViewAllSales.UseVisualStyleBackColor = true;
            this.btnViewAllSales.Click += new System.EventHandler(this.btnViewAllSales_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(419, 491);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 48);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConfirmSale
            // 
            this.btnConfirmSale.Location = new System.Drawing.Point(246, 406);
            this.btnConfirmSale.Name = "btnConfirmSale";
            this.btnConfirmSale.Size = new System.Drawing.Size(124, 48);
            this.btnConfirmSale.TabIndex = 2;
            this.btnConfirmSale.Text = "Confirm Sale";
            this.btnConfirmSale.UseVisualStyleBackColor = true;
            this.btnConfirmSale.Click += new System.EventHandler(this.btnConfirmSale_Click);
            // 
            // btnEditSales
            // 
            this.btnEditSales.Location = new System.Drawing.Point(419, 406);
            this.btnEditSales.Name = "btnEditSales";
            this.btnEditSales.Size = new System.Drawing.Size(124, 48);
            this.btnEditSales.TabIndex = 3;
            this.btnEditSales.Text = "Edit Sales";
            this.btnEditSales.UseVisualStyleBackColor = true;
            this.btnEditSales.Click += new System.EventHandler(this.btnEditSales_Click);
            // 
            // btnEditIceCream
            // 
            this.btnEditIceCream.Location = new System.Drawing.Point(580, 406);
            this.btnEditIceCream.Name = "btnEditIceCream";
            this.btnEditIceCream.Size = new System.Drawing.Size(124, 48);
            this.btnEditIceCream.TabIndex = 4;
            this.btnEditIceCream.Text = "Edit Ice Cream";
            this.btnEditIceCream.UseVisualStyleBackColor = true;
            // 
            // grpboxBaseFlavors
            // 
            this.grpboxBaseFlavors.Controls.Add(this.chkboxStrawberry);
            this.grpboxBaseFlavors.Controls.Add(this.chkboxChocolate);
            this.grpboxBaseFlavors.Controls.Add(this.chkboxVanilla);
            this.grpboxBaseFlavors.Location = new System.Drawing.Point(52, 86);
            this.grpboxBaseFlavors.Name = "grpboxBaseFlavors";
            this.grpboxBaseFlavors.Size = new System.Drawing.Size(205, 196);
            this.grpboxBaseFlavors.TabIndex = 5;
            this.grpboxBaseFlavors.TabStop = false;
            this.grpboxBaseFlavors.Text = "Base Flavors";
            // 
            // chkboxStrawberry
            // 
            this.chkboxStrawberry.AutoSize = true;
            this.chkboxStrawberry.Location = new System.Drawing.Point(19, 131);
            this.chkboxStrawberry.Name = "chkboxStrawberry";
            this.chkboxStrawberry.Size = new System.Drawing.Size(98, 21);
            this.chkboxStrawberry.TabIndex = 2;
            this.chkboxStrawberry.Text = "Strawberry";
            this.chkboxStrawberry.UseVisualStyleBackColor = true;
            // 
            // chkboxChocolate
            // 
            this.chkboxChocolate.AutoSize = true;
            this.chkboxChocolate.Location = new System.Drawing.Point(19, 87);
            this.chkboxChocolate.Name = "chkboxChocolate";
            this.chkboxChocolate.Size = new System.Drawing.Size(93, 21);
            this.chkboxChocolate.TabIndex = 1;
            this.chkboxChocolate.Text = "Chocolate";
            this.chkboxChocolate.UseVisualStyleBackColor = true;
            // 
            // chkboxVanilla
            // 
            this.chkboxVanilla.AutoSize = true;
            this.chkboxVanilla.Location = new System.Drawing.Point(19, 42);
            this.chkboxVanilla.Name = "chkboxVanilla";
            this.chkboxVanilla.Size = new System.Drawing.Size(72, 21);
            this.chkboxVanilla.TabIndex = 0;
            this.chkboxVanilla.Text = "Vanilla";
            this.chkboxVanilla.UseVisualStyleBackColor = true;
            this.chkboxVanilla.CheckedChanged += new System.EventHandler(this.chkboxVanilla_CheckedChanged);
            // 
            // grpboxToppings
            // 
            this.grpboxToppings.Controls.Add(this.chkboxGummyBears);
            this.grpboxToppings.Controls.Add(this.chkboxChocolateSauce);
            this.grpboxToppings.Controls.Add(this.chkboxSprinkles);
            this.grpboxToppings.Location = new System.Drawing.Point(313, 86);
            this.grpboxToppings.Name = "grpboxToppings";
            this.grpboxToppings.Size = new System.Drawing.Size(230, 196);
            this.grpboxToppings.TabIndex = 6;
            this.grpboxToppings.TabStop = false;
            this.grpboxToppings.Text = "Toppings";
            // 
            // chkboxGummyBears
            // 
            this.chkboxGummyBears.AutoSize = true;
            this.chkboxGummyBears.Location = new System.Drawing.Point(23, 131);
            this.chkboxGummyBears.Name = "chkboxGummyBears";
            this.chkboxGummyBears.Size = new System.Drawing.Size(119, 21);
            this.chkboxGummyBears.TabIndex = 2;
            this.chkboxGummyBears.Text = "Gummy Bears";
            this.chkboxGummyBears.UseVisualStyleBackColor = true;
            // 
            // chkboxChocolateSauce
            // 
            this.chkboxChocolateSauce.AutoSize = true;
            this.chkboxChocolateSauce.Location = new System.Drawing.Point(23, 87);
            this.chkboxChocolateSauce.Name = "chkboxChocolateSauce";
            this.chkboxChocolateSauce.Size = new System.Drawing.Size(137, 21);
            this.chkboxChocolateSauce.TabIndex = 1;
            this.chkboxChocolateSauce.Text = "Chocolate Sauce";
            this.chkboxChocolateSauce.UseVisualStyleBackColor = true;
            // 
            // chkboxSprinkles
            // 
            this.chkboxSprinkles.AutoSize = true;
            this.chkboxSprinkles.Location = new System.Drawing.Point(23, 42);
            this.chkboxSprinkles.Name = "chkboxSprinkles";
            this.chkboxSprinkles.Size = new System.Drawing.Size(88, 21);
            this.chkboxSprinkles.TabIndex = 0;
            this.chkboxSprinkles.Text = "Sprinkles";
            this.chkboxSprinkles.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // txtboxBaseFlavorTotal
            // 
            this.txtboxBaseFlavorTotal.Enabled = false;
            this.txtboxBaseFlavorTotal.Location = new System.Drawing.Point(737, 116);
            this.txtboxBaseFlavorTotal.Name = "txtboxBaseFlavorTotal";
            this.txtboxBaseFlavorTotal.Size = new System.Drawing.Size(135, 22);
            this.txtboxBaseFlavorTotal.TabIndex = 8;
            // 
            // txtboxToppingsTotal
            // 
            this.txtboxToppingsTotal.Enabled = false;
            this.txtboxToppingsTotal.Location = new System.Drawing.Point(737, 173);
            this.txtboxToppingsTotal.Name = "txtboxToppingsTotal";
            this.txtboxToppingsTotal.Size = new System.Drawing.Size(135, 22);
            this.txtboxToppingsTotal.TabIndex = 9;
            // 
            // txtboxSalesTaxTotal
            // 
            this.txtboxSalesTaxTotal.Enabled = false;
            this.txtboxSalesTaxTotal.Location = new System.Drawing.Point(737, 242);
            this.txtboxSalesTaxTotal.Name = "txtboxSalesTaxTotal";
            this.txtboxSalesTaxTotal.Size = new System.Drawing.Size(135, 22);
            this.txtboxSalesTaxTotal.TabIndex = 10;
            // 
            // txtboxGrandTotal
            // 
            this.txtboxGrandTotal.Enabled = false;
            this.txtboxGrandTotal.Location = new System.Drawing.Point(737, 304);
            this.txtboxGrandTotal.Name = "txtboxGrandTotal";
            this.txtboxGrandTotal.Size = new System.Drawing.Size(135, 22);
            this.txtboxGrandTotal.TabIndex = 11;
            // 
            // lblBaseFlavor
            // 
            this.lblBaseFlavor.AutoSize = true;
            this.lblBaseFlavor.Location = new System.Drawing.Point(587, 119);
            this.lblBaseFlavor.Name = "lblBaseFlavor";
            this.lblBaseFlavor.Size = new System.Drawing.Size(144, 17);
            this.lblBaseFlavor.TabIndex = 12;
            this.lblBaseFlavor.Text = "Total for Base Flavor:";
            // 
            // lblTotalToppings
            // 
            this.lblTotalToppings.AutoSize = true;
            this.lblTotalToppings.Location = new System.Drawing.Point(603, 178);
            this.lblTotalToppings.Name = "lblTotalToppings";
            this.lblTotalToppings.Size = new System.Drawing.Size(128, 17);
            this.lblTotalToppings.TabIndex = 14;
            this.lblTotalToppings.Text = "Total for Toppings:";
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(603, 245);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(70, 17);
            this.lblSalesTax.TabIndex = 15;
            this.lblSalesTax.Text = "Sales Tax";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(643, 309);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(88, 17);
            this.lblGrandTotal.TabIndex = 16;
            this.lblGrandTotal.Text = "Grand Total:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 712);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblSalesTax);
            this.Controls.Add(this.lblTotalToppings);
            this.Controls.Add(this.lblBaseFlavor);
            this.Controls.Add(this.txtboxGrandTotal);
            this.Controls.Add(this.txtboxSalesTaxTotal);
            this.Controls.Add(this.txtboxToppingsTotal);
            this.Controls.Add(this.txtboxBaseFlavorTotal);
            this.Controls.Add(this.grpboxToppings);
            this.Controls.Add(this.grpboxBaseFlavors);
            this.Controls.Add(this.btnEditIceCream);
            this.Controls.Add(this.btnEditSales);
            this.Controls.Add(this.btnConfirmSale);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewAllSales);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "FJ\'s Ice Cream Shop";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpboxBaseFlavors.ResumeLayout(false);
            this.grpboxBaseFlavors.PerformLayout();
            this.grpboxToppings.ResumeLayout(false);
            this.grpboxToppings.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewAllSales;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConfirmSale;
        private System.Windows.Forms.Button btnEditSales;
        private System.Windows.Forms.Button btnEditIceCream;
        private System.Windows.Forms.GroupBox grpboxBaseFlavors;
        private System.Windows.Forms.CheckBox chkboxChocolate;
        private System.Windows.Forms.CheckBox chkboxVanilla;
        private System.Windows.Forms.CheckBox chkboxStrawberry;
        private System.Windows.Forms.GroupBox grpboxToppings;
        private System.Windows.Forms.CheckBox chkboxGummyBears;
        private System.Windows.Forms.CheckBox chkboxChocolateSauce;
        private System.Windows.Forms.CheckBox chkboxSprinkles;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtboxBaseFlavorTotal;
        private System.Windows.Forms.TextBox txtboxToppingsTotal;
        private System.Windows.Forms.TextBox txtboxSalesTaxTotal;
        private System.Windows.Forms.TextBox txtboxGrandTotal;
        private System.Windows.Forms.Label lblBaseFlavor;
        private System.Windows.Forms.Label lblTotalToppings;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblGrandTotal;
    }
}

