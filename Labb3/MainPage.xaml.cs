using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Labb3
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void CalculateButton(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input.Text))
            {
                string buttonText = ((Button)sender).Text;
                double vatRate = double.Parse(buttonText.Remove(buttonText.Length - 1));
                double inputDouble = double.Parse(input.Text);

                rateLabel.Text = buttonText;
                enterdAmountLabel.Text = input.Text + " SEK";

                double amount = inputDouble / (1 + (vatRate / 100));
                double vat = inputDouble - amount;

                calculatedAmountLabel.Text = amount.ToString("0.00") + " SEK";
                outputAmountntLabel.Text = vat.ToString("0.00") + " SEK";
            }
        }

    }
}
