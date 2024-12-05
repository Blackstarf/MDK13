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
    /// Логика взаимодействия для Categories.xaml
    /// </summary>
    public partial class Categories : Page
    {
        // Сделаем это свойство публичным
        public ObservableCollection<Categorii> CategorieList { get; set; }

        public Categories()
        {
            InitializeComponent();
            // Создаём коллекцию и заполняем её данными
            CategorieList = new ObservableCollection<Categorii>
            {
                new Categorii { Name = "Молочные продукты", NameTovar = "Молоко", Count = 1010 },
                new Categorii { Name = "Мясо", NameTovar = "Свинной окорок", Count = 123 },
                new Categorii { Name = "Овощи и фрукты", NameTovar = "Картофель", Count = 545 }
            };

            // Устанавливаем DataContext для страницы
            this.DataContext = this;
        }
    }

    // Убедимся, что класс Categorii тоже доступен
    public class Categorii
    {
        public string Name { get; set; }
        public string NameTovar { get; set; }
        public int Count { get; set; }
    }
}
