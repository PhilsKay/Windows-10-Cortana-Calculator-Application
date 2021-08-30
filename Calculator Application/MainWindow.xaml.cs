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

namespace Calculator_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            calculationTextBox.Text =null ;
            resultTextBox.Text = "0";
        }
        string userInput = string.Empty;
        char operation = ' ';
        string operand1 = " ";
        string operand2 = " ";

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            calculationTextBox.Clear();
            userInput = string.Empty;
            resultTextBox.Text = "0";
        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            operand1 = userInput;
            userInput = string.Empty;
            operation = '/';
            calculationTextBox.Text += operation.ToString();
        }

        private void timesButton_Click(object sender, RoutedEventArgs e)
        {
            operand1 = userInput;
            userInput = string.Empty;
            operation = 'x';
            calculationTextBox.Text += operation.ToString();
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            operand1 = userInput;
            userInput = string.Empty;
            operation = '-';
            calculationTextBox.Text += operation.ToString();
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            operand1 = userInput;
            userInput = string.Empty;
            operation = '+';
            calculationTextBox.Text += operation.ToString();
        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            userInput += zeroButton.Content;
            calculationTextBox.Text += zeroButton.Content;
        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            userInput += oneButton.Content;
            calculationTextBox.Text += oneButton.Content;
        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {
            userInput += twoButton.Content;
            calculationTextBox.Text += twoButton.Content;
        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {
            userInput += threeButton.Content;
            calculationTextBox.Text += threeButton.Content;
        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            userInput += fourButton.Content;
            calculationTextBox.Text += fourButton.Content;
        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            userInput += fiveButton.Content;
            calculationTextBox.Text += fiveButton.Content;
        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            userInput += sixButton.Content;
            calculationTextBox.Text += sixButton.Content;
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            userInput += sevenButton.Content;
            calculationTextBox.Text += sevenButton.Content;
        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            userInput += eightButton.Content;
            calculationTextBox.Text += eightButton.Content;
        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            userInput += nineButton.Content;
            calculationTextBox.Text += nineButton.Content;
        }

        private void pointButton_Click(object sender, RoutedEventArgs e)
        {
            userInput += pointButton.Content;
            calculationTextBox.Text += pointButton.Content;
        }

        private void equalButton_Click(object sender, RoutedEventArgs e)
        {
            calculationTextBox.Text += equalButton.Content; 
            operand2 = userInput;
            double num1;
            double num2;
            bool firstSucceed = double.TryParse(operand1, out num1);
            bool secondSucceed = double.TryParse(operand2, out num2);
            if (operation == '+')
            {
                resultTextBox.Text = ((double)Math.Round((num1 + num2), 3)).ToString();
                resultTextBox.FontSize = 50;
            }
            else if(operation == '-')
            {
                resultTextBox.Text = ((double)Math.Round((num1 - num2),3)).ToString();
                resultTextBox.FontSize = 50;
            }
            else if(operation == 'x')
            {
                resultTextBox.Text = ((double)Math.Round((num1 * num2),3)).ToString();
                resultTextBox.FontSize = 50;
            }
            else if(operation == '%')
            {
                resultTextBox.Text = ((double)Math.Round((num1 % num2), 3)).ToString();
                resultTextBox.FontSize = 50;
            }
            else
            {
                resultTextBox.Text = ((double)Math.Round((num1 / num2), 3)).ToString();
                if(num2 == 0)
                {
                    resultTextBox.Text = "Attemped to divide by zero";
                    resultTextBox.FontSize = 25;
                }
            }
        }

        private void closedBracketButton_Click(object sender, RoutedEventArgs e)
        {

            userInput += ")";
            calculationTextBox.Text += ")";
        }

        private void openedBracketButton_Click(object sender, RoutedEventArgs e)
        {
            userInput += "(";
            calculationTextBox.Text += "(";
        }

        private void remainderButton_Click(object sender, RoutedEventArgs e)
        {
            operand1 = userInput;
            userInput = string.Empty;
            operation = '%';
            calculationTextBox.Text += remainderButton.Content;
        }
    }
}
