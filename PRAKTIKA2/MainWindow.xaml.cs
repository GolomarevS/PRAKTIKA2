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

namespace PRAKTIKA2
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
        private void AAA(object sender, RoutedEventArgs e)
        {
            int x = Convert.ToInt32(AAA);  // Длина строки
            string text = Convert.ToString(AAA); // Текст

            if (text.Length == x)
            {
                text = text.Replace("ogogo", "***");
                text = text.Replace("ogo", "***");
                text = text.Replace("*g*", "**");
                text = text.Replace("*go", "*");

                for (int i = 0; i < 100; i++)
                {
                    text = text.Replace("******", "***");
                }

                AAA = Convert.ToString(text); // Вывод
            }
            else { AAA = Convert.ToString(" Ошибка! Неверное количество символов. "); } // Вывод
        }
    }
}
