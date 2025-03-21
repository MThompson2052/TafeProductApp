﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductApps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Product cProduct;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double price, totalPayment, totalCharge, quantity, totalWrap, totalGST;

            price = double.Parse(priceTextBox.Text);
            quantity = double.Parse(quantityTextBox.Text);

            totalPayment = price * quantity;
            totalPaymentTextBlock.Text = totalPayment.ToString();

            totalCharge = totalPayment + 25;
            totalChargeTextBlock.Text = totalCharge.ToString("C");

            totalWrap = totalCharge + 5;
            totalWrapTextBlock.Text = totalWrap.ToString("C");

            totalGST = totalWrap * 1.1;
            gstTextBlock.Text = totalGST.ToString("C");

        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            productTextBox.Text = "";
            priceTextBox.Text = "";
            quantityTextBox.Text = "";
            totalPaymentTextBlock.Text = "";
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
