using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Get the status of the main course radio
            // buttons and assign them to variables
            var isBurgerChecked = radHamburger.Checked;
            var isPizzaChecked = radPizza.Checked;
            var isSaladChecked = radSalad.Checked;

            // Get the status of the add-on checkboxes
            // and assign them to variables
            var isChk1Checked = chk1.Checked;
            var isChk2Checked = chk2.Checked;
            var isChk3Checked = chk3.Checked;

            // Create a variable for the main course and add-on price
            double mainPrice = 0.00;
            double addOnPrice = 0.00;
            double totalAddOnPrice = 0.00;
            double subTotal = 0.00;
            double tax = 0.00;
            double total = 0.00;

            // set the mainPrice and addOnPrice variable based
            // on the value of the main course selection
            if (isBurgerChecked)
            {
                mainPrice = 6.95;
                addOnPrice = 0.75;
            }
            else if (isPizzaChecked)
            {
                mainPrice = 5.95;
                addOnPrice = 0.50;
            }
            else
            {
                mainPrice = 4.95;
                addOnPrice = 0.25;
            }

            // set the mainPrice and addOnPrice variable based
            // on the value of the main course selection
            if (isChk1Checked)
            {
                totalAddOnPrice += addOnPrice;
            }
            if (isChk2Checked)
            {
                totalAddOnPrice += addOnPrice;
            }
            if (isChk3Checked)
            {
                totalAddOnPrice += addOnPrice;
            }

            // Add the main course price to the add-on
            // price and print it to the text label
            subTotal = mainPrice + addOnPrice;
            txtSubtotal.Text = subTotal.ToString("C"); // Currency format

            // Calculate the sales tax and print it to the text label
            tax = subTotal * 0.0775;
            txtTax.Text = tax.ToString("C");

            // Calculate the order total and print it to the text label
            total = subTotal + tax;
            txtTotal.Text = total.ToString("C");
        }

        // Method used to clear the Subtotal, Sales Tax, and Order Total textboxes
        public void ClearTotals()
        {
            // Clear the textboxes
            txtSubtotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
        }

        // Method used to clear the add-on checkboxes
        public void ClearAddOns()
        {
            // Clear the checkboxes
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
        }

        private void radHamburger_CheckedChanged(object sender, EventArgs e)
        {
            // Change the add-on items when a main course item is selected
            gbAddOnItems.Text = "Add-on items ($.75/each)";
            chk1.Text = "Lettuce, tomato, and onions";
            chk2.Text = "Ketchup, mustard, and mayo";
            chk3.Text = "French fries";

            // Clear the add-on checkboxes
            ClearAddOns();

            // Clear the total textboxes
            ClearTotals();
        }

        private void radPizza_CheckedChanged(object sender, EventArgs e)
        {
            // Change the add-on items when a main course item is selected
            gbAddOnItems.Text = "Add-on items ($.50/each)";
            chk1.Text = "Pepperoni";
            chk2.Text = "Sausage";
            chk3.Text = "Olives";

            // Clear the add-on checkboxes
            ClearAddOns();

            // Clear the total textboxes
            ClearTotals();
        }

        private void radSalad_CheckedChanged(object sender, EventArgs e)
        {
            // Change the add-on items when a main course item is selected
            gbAddOnItems.Text = "Add-on items ($.25/each)";
            chk1.Text = "Croutons";
            chk2.Text = "Bacon bits";
            chk3.Text = "Bread sticks";

            // Clear the add-on checkboxes
            ClearAddOns();

            // Clear the total textboxes
            ClearTotals();
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            // Clear the total textboxes
            ClearTotals();
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            // Clear the total textboxes
            ClearTotals();
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            // Clear the total textboxes
            ClearTotals();
        }
    }
}