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

namespace Lab1
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

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            a.Clear();
            b.Clear(); 
            c.Clear();
            result.Text = "";
        }
        private void a_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(a.Text, "[^0-9]"))
            {
                MessageBox.Show("Пожалуйста вводите только цифры");
                a.Text = a.Text.Remove(a.Text.Length - 1);
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(b.Text, "[^0-9]"))
            {
                MessageBox.Show("Пожалуйста вводите только цифры");
                b.Text = b.Text.Remove(b.Text.Length - 1);
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(c.Text, "[^0-9]"))
            {
                MessageBox.Show("Пожалуйста вводите только цифры");
                c.Text = c.Text.Remove(c.Text.Length - 1);
            }
        }

        private void sure_Click(object sender, RoutedEventArgs e)
        {
            double z, v, o;
            if (a.Text == "")
            {
                MessageBox.Show("Вы не ввели 1 сторону");
                return;

            }
            if (b.Text == "")
            {
                MessageBox.Show("Вы не ввели 2 сторону");
                return;
            }
            if (c.Text == "")
            {
                MessageBox.Show("Вы не ввели 3 сторону");
                return;
            }
            
            z = Convert.ToDouble(a.Text);
            v = Convert.ToDouble(b.Text);
            o = Convert.ToDouble(c.Text);

            if (z <= 0)
            {
                MessageBox.Show("Вы ввели некорректное число");
                return;

            }
            if (v <= 0)
            {
                MessageBox.Show("Вы ввели некорректное число");
                return;

            }
            if (o <= 0)
            {
                MessageBox.Show("Вы ввели некорректное число");
                return;

            }
            if (((z + v) > o) && ((v + o) > z) && ((z + o) > v))
            {
                result.Text = "";
            }
            else
            {
                result.Text = "";
                result.Text = "Такого треугольника не может существовать";
                return;
            }

            if (z <= 0 || v <= 0 || o <= 0)
            {
                result.Text = "";
                result.Text = "Введённая сторона не может существовать(<= 0)\n";
                return;
            }

            if (z == v && v == o)
            {
                result.Text = "";
                result.Text = "Треугольник равносторонний";
                return;
            }
            else if (z == v || v == o || z == o)
            {
                result.Text = "";
                result.Text = "Треугольник равнобедренный";
                return;
            }
            else
            {
                result.Text = "";
                result.Text = "Треугольник разносторонний";
                return;
            }

        }

        
    }
}
