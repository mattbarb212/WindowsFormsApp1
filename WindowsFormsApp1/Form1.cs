using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class cashRegister : Form
    {
        //Global Variable

        int burgersNumber = 0;
        int friesNumber = 0;
        int drinksNumber = 0;
        double tenderedNumber = 0;
        double burgerPrice = 5.00;
        double friesPrice = 3.50;
        double drinksPrice = 20.00;
        double subTotalPrice = 0;
        double taxRate = 0.13;
        double taxAmount = 0;
        double totalPrice = 0;
        double changeDue = 0;
        double orderNumber = 132;


        public cashRegister()
        {
            InitializeComponent();
        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                burgersNumber = Convert.ToInt32(burgersTextBox.Text);
                friesNumber = Convert.ToInt32(friesTextBox.Text);
                drinksNumber = Convert.ToInt32(drinksTextBox.Text);
                subTotalPrice = burgersNumber * burgerPrice + friesNumber * friesPrice + drinksNumber * drinksPrice;
                subTotalPriceLabel.Text = $"{subTotalPrice.ToString("C")}";

                Refresh();
                Thread.Sleep(500);

                taxAmount = subTotalPrice * taxRate;
                taxPriceLabel.Text = $"{taxAmount.ToString("C")}";

                Refresh();
                Thread.Sleep(500);

                totalPrice = subTotalPrice + taxAmount;
                totalPriceLabel.Text = $"{totalPrice.ToString("C")}";
            }
            catch
            {
                recieptOutputLabel.Text = $"Please Input Whole Numbers Into The Choices";
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tenderedNumber = Convert.ToInt32(tenderedTextBox.Text);
                changeDue = tenderedNumber - totalPrice;
                changePriceLabel.Text = $"{changeDue.ToString("C")}";
            }
            catch
            {
                recieptOutputLabel.Text = $"Please Enter The Amount of Money Paid";
            }
        }

        private void PrintRecieptButton_Click(object sender, EventArgs e)
        {
            NameLabel.Visible = true;

            Refresh();
            Thread.Sleep(500);

            recieptOutputLabel.Text += $"\n\n\nOrder Number {orderNumber++}";

            Refresh();
            Thread.Sleep(500);

            recieptOutputLabel.Text += 
        }
    }
}
