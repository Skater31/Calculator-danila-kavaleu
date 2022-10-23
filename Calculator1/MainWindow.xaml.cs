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

namespace Calculator1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    
    public partial class MainWindow : Window
    {
        private decimal first = 0.0m;
        private decimal second = 0.0m;
        private char op;
        private static decimal result;
        

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            if(!Result.Text.Contains("."))
            {
                Result.Text = Result.Text + ".";
            }
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if(Result.Text == "0")
            {
                Result.Text = "0";
                second = Decimal.Parse(Result.Text);
            }
            else
            {
                Result.Text += "0";
                second = Decimal.Parse(Result.Text);
            }
        }
        private void One_Click(object sender, RoutedEventArgs e)
        {
            if(Result.Text == "0")
            {
                Result.Text = "1";
                second = Decimal.Parse(Result.Text);
            }
            else
            {
                Result.Text += "1";
                second = Decimal.Parse(Result.Text);
            }
        }
        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if(Result.Text == "0")
            {
                Result.Text = "2";
                second = Decimal.Parse(Result.Text);
            }
            else
            {
                Result.Text += "2";
                second = Decimal.Parse(Result.Text);
            }
        }
        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if(Result.Text == "0")
            {
                Result.Text = "3";
                second = Decimal.Parse(Result.Text);
            }
            else
            {
                Result.Text += "3";
                second = Decimal.Parse(Result.Text);
            }
        }
        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if(Result.Text == "0")
            {
                Result.Text = "4";
                second = Decimal.Parse(Result.Text);
            }
            else
            {
                Result.Text += "4";
                second = Decimal.Parse(Result.Text);
            }
        }
        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if(Result.Text == "0")
            {
                Result.Text = "5";
                second = Decimal.Parse(Result.Text);
            }
            else
            {
                Result.Text += "5";
                second = Decimal.Parse(Result.Text);
            }
        }
        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if(Result.Text == "0")
            {
                Result.Text = "6";
                second = Decimal.Parse(Result.Text);
            }
            else
            {
                Result.Text += "6";
                second = Decimal.Parse(Result.Text);
            }
        }
        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if(Result.Text == "0")
            {
                Result.Text = "7";
                second = Decimal.Parse(Result.Text);
            }
            else
            {
                Result.Text += "7";
                second = Decimal.Parse(Result.Text);
            }
        }
        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if(Result.Text == "0")
            {
                Result.Text = "8";
                second = Decimal.Parse(Result.Text);
            }
            else
            {
                Result.Text += "8";
                second = Decimal.Parse(Result.Text);
            }
        }
        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if(Result.Text == "0")
            {
                Result.Text = "9";
                second = Decimal.Parse(Result.Text);

            }
            else
            {
                Result.Text += "9";
                second = Decimal.Parse(Result.Text);
            }
        }

        public void Plus_Click(object sender, RoutedEventArgs e)
        {           
                first = Decimal.Parse(Result.Text);
                op = '+';
                Result.Clear();             
        }

        public void Minus_Click(object sender, RoutedEventArgs e)
        {          
                first = Decimal.Parse(Result.Text);
                op = '-';
                Result.Clear();          
        }

        public void Multiply_Click(object sender, RoutedEventArgs e)
        {         
                first = Decimal.Parse(Result.Text);
                op = '*';
                Result.Clear();                
        }

        public void Divide_Click(object sender, RoutedEventArgs e)
        {

                first = Decimal.Parse(Result.Text);
                op = '/';
                Result.Clear();
            
        }
        public void RemainderOfDivision_Click(object sender, RoutedEventArgs e)
        {
            first = Decimal.Parse(Result.Text);
            op = '%';
            Result.Clear();
        }
        public void ChangeSign_Click(object sender, RoutedEventArgs e)
        {
            if(Result.Text.Contains("-"))
            {
                Result.Text = Result.Text.Trim('-');
            }
            else
            {
                Result.Text = "-" + Result.Text;
            }
        }


        public void CE_Click(object sender, RoutedEventArgs e)
        {
           first = 0.0m;
           second = 0.0m;
           Result.Text = "0";
        }

        public void Equal_Click(object sender, RoutedEventArgs e)
        {
            second = Decimal.Parse(Result.Text);

            var res = Calculate(first, second, op);

            Result.Text = res.ToString();

            first = Convert.ToDecimal(res);
        }     

        public static decimal Calculate(decimal first, decimal second, char op)
        {          
            switch(op)
            {
                case '+':
                    result = first + second;
                    break;

                case '-':
                    result = first - second;
                    break;

                case '*':
                    result = first * second;
                    break;

                case '%':
                    result = first % second;
                    break;

                case '/':
                    try
                    {
                        result = first / second;
                        break;
                    }
                    catch (DivideByZeroException)
                    {
                        break;
                    }                                                             
            }

            return result;
        }
    }
}