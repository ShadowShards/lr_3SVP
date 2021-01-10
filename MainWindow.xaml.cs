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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        float a, b;
        int count;
        bool znak = true;
        char[] symbol = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        char[] first = { '+', '-', '*', '/' };
        private void one_Click(object sender, RoutedEventArgs e)
        {
            tablo.Text = tablo.Text + 1;
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            tablo.Text = tablo.Text + 2;
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            tablo.Text = tablo.Text + 3;
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            tablo.Text = tablo.Text + 4;
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            tablo.Text = tablo.Text + 5;
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            tablo.Text = tablo.Text + 6;
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            tablo.Text = tablo.Text + 7;
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            tablo.Text = tablo.Text + 8;
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            tablo.Text = tablo.Text + 9;
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            tablo.Text = tablo.Text + 0;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            tablo.Text = "";
            Label1.Content = "";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if(tablo.Text == string.Empty)
            {
                MessageBox.Show("Не корректный ввод!");
                return;
            }
      
            a = float.Parse(tablo.Text);
            tablo.Clear();
            count = 1;
            Label1.Content = a.ToString() + "+";
            znak = true;
        }

        private void min_Click(object sender, RoutedEventArgs e)
        {
            if (tablo.Text == string.Empty)
            {
                MessageBox.Show("Не корректный ввод!");
                return;
            }
            a = float.Parse(tablo.Text);
            tablo.Clear();
            count = 2;
            Label1.Content = a.ToString() + "-";
            znak = true;
        }

        private void umn_Click(object sender, RoutedEventArgs e)
        {
            if (tablo.Text == string.Empty)
            {
                MessageBox.Show("Не корректный ввод!");
                return;
            }
            a = float.Parse(tablo.Text);

            tablo.Clear();
            count = 3;
            Label1.Content = a.ToString() + "*";
            znak = true;
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            if (tablo.Text == string.Empty)
            {
                MessageBox.Show("Не корректный ввод!");
                return;
            }
            a = float.Parse(tablo.Text);
            tablo.Clear();
            count = 4;
            Label1.Content = a.ToString() + "/";
            znak = true;
        }

        private void res_Click(object sender, RoutedEventArgs e)
        {
            calculate();
            Label1.Content = "";
        }

        private void lust_Click(object sender, RoutedEventArgs e)
        {
            int lenght = tablo.Text.Length - 1;
            string text = tablo.Text;
            tablo.Clear();
            for (int i = 0; i < lenght; i++)
            {
                tablo.Text = tablo.Text + text[i];
            }
        }

        private void Znak_Click(object sender, RoutedEventArgs e)
        {
            if (znak == true)
            {
                tablo.Text = "-" + tablo.Text;
                znak = false;
            }
            else if (znak == false)
            {
                tablo.Text = tablo.Text.Replace("-", "");
                znak = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tablo.Text == string.Empty)
            {
                MessageBox.Show("Не корректный ввод!");
                return;
            }
            if (tablo.Text.IndexOf(',') == -1)
            {
                tablo.Text += ",";
            }
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(tablo.Text);
                    tablo.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(tablo.Text);
                    tablo.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(tablo.Text);
                    tablo.Text = b.ToString();
                    break;
                case 4:
                    float divider;
                    divider = float.Parse(tablo.Text);
                    if (divider == 0.0)
                        MessageBox.Show("Внимание!Деление на ноль!");
                    else
                    {
                        b = a / divider;
                        tablo.Text = b.ToString();
                    }
                    break;

                default:
                    break;
            }

        }
    }
}
