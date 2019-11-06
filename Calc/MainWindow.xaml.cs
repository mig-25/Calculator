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
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Content == ",")
            {
                if (!textBox_Result.Text.Contains(","))
                    textBox_Result.Text = textBox_Result.Text + button.Content;

            }
            else
                textBox_Result.Text = textBox_Result.Text + button.Content;


        }

        private void operator_click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            
            if (resultValue != 0)
            {
                btnEquals.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                operationPerformed = button.Content;
                labelCurrentOperation.Content = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Content;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Content = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
           
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Content = "";
        }

        private void btnBackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (operationPerformed == "")
            {
                //code to implement
            }
            else
            {
                //Code to implement
            }
        }

        private void btnPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if (operationPerformed == "")
            {
                //Code to implement
            }
            else
            {
                //Code to implement
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDecimal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textBox_Result_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
