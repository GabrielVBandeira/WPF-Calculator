using System;
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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double aux = 0;

        string operation = "";

        string output = "";
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            DivideBtn.Content = "\u00F7";
        }

        private void NumBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch(name)
            {
                case "OneBtn":
                    output += "1";
                    OutputCalculator.Text = output;
                    break;

                case "TwoBtn":
                    output += "2";
                    OutputCalculator.Text = output;
                    break;

                case "ThreeBtn":
                    output += "3";
                    OutputCalculator.Text = output;
                    break;

                case "FourBtn":
                    output += "4";
                    OutputCalculator.Text = output;
                    break;

                case "FiveBtn":
                    output += "5";
                    OutputCalculator.Text = output;
                    break;

                case "SixBtn":
                    output += "6";
                    OutputCalculator.Text = output;
                    break;

                case "SevenBtn":
                    output += "7";
                    OutputCalculator.Text = output;
                    break;

                case "EightBtn":
                    output += "8";
                    OutputCalculator.Text = output;
                    break;

                case "NineBtn":
                    output += "9";
                    OutputCalculator.Text = output;
                    break;

                case "ZeroBtn":
                    output += "0";
                    OutputCalculator.Text = output;
                    break;
            }

        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                aux = double.Parse(output);

                output = "";

                operation = "Minus";
            }
        }

        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "Minus":
                    double outputMinus = aux - double.Parse(output);
                    output = outputMinus.ToString();
                    OutputCalculator.Text = output;
                    break;

                case "Plus":
                    double outputPlus = aux + double.Parse(output);
                    output = outputPlus.ToString();
                    OutputCalculator.Text = output;
                    break;

                case "Multiple":
                    double outputMultiple = aux * double.Parse(output);
                    output = outputMultiple.ToString();
                    OutputCalculator.Text = output;
                    break;

                case "Divide":
                    double outputDivide = aux / double.Parse(output);
                    output = outputDivide.ToString();
                    OutputCalculator.Text = output;
                    break;

            }
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                aux = double.Parse(output);

                output = "";

                operation = "Plus";
            }
        }

        private void MultipleBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                aux = double.Parse(output);

                output = "";

                operation = "Multiple";
            }
        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                aux = double.Parse(output);

                output = "";

                operation = "Divide";
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            
            output = "";
            OutputCalculator.Text = "";
            

        }
    }
}

