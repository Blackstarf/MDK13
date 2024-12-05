using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Analis
{
    /// <summary>
    /// Логика взаимодействия для Periods.xaml
    /// </summary>
    public partial class Periods : Page
    {
        public ObservableCollection<Period> PeriodList { get; set; } // Переименовали свойство

        public Periods()
        {
            InitializeComponent();

            // Создаём коллекцию и заполняем её данными
            PeriodList = new ObservableCollection<Period> // Обновили имя свойства
            {
                new Period { Cvartal = "Квартал 1", Tovar = "Картофель", Count = 10 },
                new Period { Cvartal = "Квартал 3", Tovar = "Свинной окорок", Count = 10 },
                new Period { Cvartal = "Квартал 2", Tovar = "Молоко", Count = 5 }
            };

            // Устанавливаем DataContext для страницы
            this.DataContext = this;
        }
    }

    // Сделали класс Period публичным
    public class Period
    {
        public string Cvartal { get; set; }
        public string Tovar { get; set; }
        public int Count { get; set; }
    }
}
