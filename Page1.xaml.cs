using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Analis
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public ObservableCollection<Tovar> TovarsList { get; set; }

        public Page1()
        {
            InitializeComponent();
            TovarsList = new ObservableCollection<Tovar>
            {
                new Tovar { NameTovar = "Картофель", Price = 33, Count = 134 },
                new Tovar { NameTovar = "Молоко", Price = 79, Count = 102 },
                new Tovar { NameTovar = "Свинной окорок", Price = 249, Count = 57 }
            };

            // Устанавливаем DataContext для страницы
            this.DataContext = this;
        }
    }

    // Сделаем класс Tovar публичным
    public class Tovar
    {
        public string NameTovar { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
    }
}
