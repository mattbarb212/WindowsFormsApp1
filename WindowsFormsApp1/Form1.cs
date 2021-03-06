﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class cashRegister : Form
    {
        //Matthew Barber
        //Mr.Theordoreopolous
        //2.11.21
        //Cash Register Assignment


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
        double totalBurgersPrice = 0;
        double totalFriesPrice = 0;
        double totalDrinksPrice = 0;




        public cashRegister()
        {
            InitializeComponent();
        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
            //This uses the variables typed into the numbers of food items to caltulate the total

            try
            {
                recieptOutputLabel.Text = "";
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
            //Uses variables to calculate the change


            try
            {
                recieptOutputLabel.Text = "";
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
            //Uses the variables to print off all the information


            recieptOutputLabel.Text = "";
            dateLabel.Text = "";
            recieptNames.Text = "";
            recieptFoodAmounts.Text = "";
            recieptPrices.Text = "";
            thankYouOutput.Text = "";

            totalBurgersPrice = burgersNumber * burgerPrice;
            totalFriesPrice = friesNumber * friesPrice;
            totalDrinksPrice = drinksNumber * drinksPrice;

            SoundPlayer recieptSound = new SoundPlayer(Properties.Resources._345056__azumarill__epson_receipt_printer3);
            recieptSound.Play();

            nameLabel.Visible = true;

            Refresh();
            Thread.Sleep(500);

            dateLabel.Text += $"  Order Number {orderNumber++}";

            Refresh();
            Thread.Sleep(500);

            dateLabel.Text += $"\n  February 11, 2021";

            Refresh();
            Thread.Sleep(500);

            recieptNames.Text += $"\n  Hamburgers";
            recieptFoodAmounts.Text += $"\nx{burgersNumber} @";
            recieptPrices.Text += $"\n{totalBurgersPrice.ToString("C")}";

            Refresh();
            Thread.Sleep(500);

            recieptNames.Text += $"\n  Fries";
            recieptFoodAmounts.Text += $"\nx{friesNumber} @";
            recieptPrices.Text += $"\n{totalFriesPrice.ToString("C")}";

            Refresh();
            Thread.Sleep(500);

            recieptNames.Text += $"\n  Drinks";
            recieptFoodAmounts.Text += $"\nx{drinksNumber} @";
            recieptPrices.Text += $"\n{totalDrinksPrice.ToString("C")}";

            Refresh();
            Thread.Sleep(500);

            recieptNames.Text += $"\n\n  Subtotal";
            recieptPrices.Text += $"\n\n{subTotalPrice.ToString("C")}";

            Refresh();
            Thread.Sleep(500);

            recieptNames.Text += $"\n  Tax";
            recieptPrices.Text += $"\n{taxAmount.ToString("C")}";

            Refresh();
            Thread.Sleep(500);

            recieptNames.Text += $"\n  Total";
            recieptPrices.Text += $"\n{totalPrice.ToString("C")}";

            Refresh();
            Thread.Sleep(500);

            recieptNames.Text += $"\n\n  Tendered";
            recieptPrices.Text += $"\n\n{tenderedNumber.ToString("C")}";

            Refresh();
            Thread.Sleep(500);

            recieptNames.Text += $"\n  Change";
            recieptPrices.Text += $"\n{changeDue.ToString("C")}";

            Refresh();
            Thread.Sleep(500);

            thankYouOutput.Text += $"Thank You For Your Purchase";
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            //Clears everything


            recieptOutputLabel.Text = "";
            nameLabel.Visible = false;
            burgersTextBox.Text = "";
            friesTextBox.Text = "";
            drinksTextBox.Text = "";
            subTotalPriceLabel.Text = "";
            taxPriceLabel.Text = "";
            totalPriceLabel.Text = "";
            tenderedTextBox.Text = "";
            changePriceLabel.Text = "";
            dateLabel.Text = "";
            recieptNames.Text = "";
            recieptFoodAmounts.Text = "";
            recieptPrices.Text = "";
            thankYouOutput.Text = "";
            burgersNumber = 0;
            friesNumber = 0;
            drinksNumber = 0;
            tenderedNumber = 0;
            burgerPrice = 5.00;
            friesPrice = 3.50;
            drinksPrice = 20.00;
            subTotalPrice = 0;
            taxRate = 0.13;
            taxAmount = 0;
            totalPrice = 0;
            changeDue = 0;
            orderNumber = 132;
            totalBurgersPrice = 0;
            totalFriesPrice = 0;
            totalDrinksPrice = 0;
        }
    }
}
