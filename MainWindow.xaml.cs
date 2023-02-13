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

namespace task13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Phone> phones;
        public MainWindow()
        {
            InitializeComponent();
            phones = new List<Phone>
            {
                new Phone { Company = "Apple", Title = "iPhone 10", Price = 58000},
                new Phone { Company = "Xiaomi", Title = "Redmi Note 10S", Price = 28000 },
                new Phone { Company = "Apple", Title = "iPhone 12 Pro Max Super Idol", Price = 158000},
                new Phone { Company = "Nokia", Title = "3310", Price = 800}
            };
            mainListBox.ItemsSource = phones;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            phones.Add(new Phone
            {
                Company = companyView.Text,
                Title = titleView.Text,
                Price = Convert.ToDecimal(priceView.Text)
            });
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            phones.Remove(mainListBox.SelectedItem as Phone);
        }
    }
}
