using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Threading;


namespace MDK12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;//Описываем таймер
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0,0,0,1,0);
            timer.IsEnabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;//Создание объекта
            time.Text = d.ToString("HH:mm:ss");//Время
            data.Text = d.ToString("dd.MM.yyyy");//Дата
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Агальцов Д. Практическая работа №12 Реализовать расчет задачи: 1)Даны длины ребер a, b, c прямоугольного параллелепипеда.Найти его объем V = a·b·c и площадь поверхности S = 2·(a·b + b·c + a·c). 2)Дано двузначное число.Найти сумму и произведение его цифр.");
        }

        private void First(object sender, RoutedEventArgs e)
        {
            bool f = Int32.TryParse(tb1.Text, out int a);
            bool f1 = Int32.TryParse(tb3.Text, out int b);
            bool f2 = Int32.TryParse(tb2.Text, out int c);
            if (f && f1 && f2 && a > 0 && b > 0 && c > 0)
            {
                Class1 class1 = new Class1();
                int volume; int area;
                class1.Par(a, b, c,out area,out volume);
                tb4.Text = area.ToString();
                tb5.Text = volume.ToString();
            }
            else MessageBox.Show("Данные заполнены неверно или вовсе не заполнены","ОШИБКА",MessageBoxButton.OK,MessageBoxImage.Error);
        }

        private void Second(object sender, RoutedEventArgs e)
        {
            bool f = Int32.TryParse(tb6.Text, out int a);
            if(f && a > 9 && a < 100)
            {
                Class1 class1 = new Class1();
                int sum;int proiz;
                class1.Calc(a, out sum, out proiz);
                tb7.Text = sum.ToString();
                tb8.Text = proiz.ToString();
            }
            else MessageBox.Show("Данные заполнены неверно или вовсе не заполнены", "ОШИБКА", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Clear1 (object sender, RoutedEventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
            tb4.Clear();
            tb5.Clear();
        }

        private void Clear2(object sender, RoutedEventArgs e)
        {
             tb6.Clear();
             tb7.Clear();
             tb8.Clear();
        }

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            tb4.Clear();
            tb5.Clear();
        }

        private void tb3_TextChanged(object sender, TextChangedEventArgs e)
        {
            tb4.Clear();
            tb5.Clear();
        }

        private void tb2_TextChanged(object sender, TextChangedEventArgs e)
        {
            tb4.Clear();
            tb5.Clear();
        }

        private void tb6_TextChanged(object sender, TextChangedEventArgs e)
        {
            tb7.Clear();
            tb8.Clear();
        }
    }
}
