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

namespace FinalTaskWpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a, b, c;
        int count;
        bool sign = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + 2;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + 3;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + 4;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + 5;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + 6;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + 7;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + 8;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + 9;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + ",";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textBox.Text);
            textBox.Clear();
            count = 2;
            label.Content = a.ToString() + "-";
            sign = true;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textBox.Text);
            textBox.Clear();
            count = 3;
            label.Content = a.ToString() + "*";
            sign = true;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textBox.Text);
            textBox.Clear();
            count = 4;
            label.Content = a.ToString() + "/";
            sign = true;
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            calculate();
            label.Content = "";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textBox.Text);
            textBox.Clear();
            count = 1;
            label.Content = a.ToString() + "+";
            sign = true;
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            label.Content = "";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            label.Content = "";
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            int lenght = textBox.Text.Length - 1;
            string text = textBox.Text;
            textBox.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox.Text = textBox.Text + text[i];
            }
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {

            a = Convert.ToDouble(textBox.Text);
            textBox.Clear();
            if (a != 0)
            {
                b = 1 / a;
                label.Content = $"1/{a}";
                sign = true;
                textBox.Text = Convert.ToString(b);
            }
            else textBox.Text = "Деление на ноль невозможно";
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            b = Convert.ToDouble(textBox.Text);
            textBox.Clear();
            label.Content = b.ToString() + "%";
            sign = true;
            c = a * b / 100;
            textBox.Text = Convert.ToString(c);
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textBox.Text);
            textBox.Clear();
            if (a >= 0)
            {
                b = Math.Sqrt(a);
                textBox.Text = Convert.ToString(b);
                label.Content = $"√{a}";
                sign = true;
            }
            else textBox.Text = "Неверный ввод";
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textBox.Text);
            textBox.Clear();
            count = 5;
            label.Content = a.ToString() + $"степень?";
            sign = true;
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            if (sign == true)
            {
                textBox.Text = "-" + textBox.Text;
                sign = false;
            }
            else if (sign == false)
            {
                textBox.Text = textBox.Text.Replace("-", "");
                sign = true;
            }
        }

        private void calculate()
        {
            b = Convert.ToDouble(textBox.Text);
            switch (count)
            {
                case 1:
                    c = a + b;
                    break;
                case 2:
                    c = a - b;
                    break;
                case 3:
                    c = a * b;
                    break;
                case 4:
                    c = a / b;
                    break;
                case 5:
                    c = Math.Pow(a, b);
                    break;

                default:
                    break;
            }
            textBox.Text = Convert.ToString(c);
        }
    }
}
