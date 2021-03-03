using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        private int currentState;
        private string mathOperator;
        private double firstNumber;
        private double secondNumber;

        public MainPage()
        {
            InitializeComponent();
            OnClear(null, null);
        }

        private void OnSelectNumber(object sender, EventArgs e)
        {
        }

        private void OnSelectOperator(object sender, EventArgs e)
        {
        }

        private void OnClear(object sender, EventArgs e)
        {
            currentState = default;
            mathOperator = default;
            firstNumber = default;
            secondNumber = default;
            resultText.Text = "0";
        }

        private void OnCalculate(object sender, EventArgs e)
        {
        }

        private void OnPage(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page1());
        }
    }
}
