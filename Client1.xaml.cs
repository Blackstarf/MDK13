using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Analis
{
    public partial class Clients : Page
    {
        public ObservableCollection<Client> ClientList { get; set; } // Переименовали свойство

        public Clients() // Конструктор остался без изменений
        {
            InitializeComponent();

            // Создаём коллекцию и заполняем её данными
            ClientList = new ObservableCollection<Client> // Обновили имя свойства
            {
                new Client { ClientName = "Иванов Иван", Tovars = "Картофель", Count = 10 },
                new Client { ClientName = "Сидоров Сидор", Tovars = "Свинной окорок", Count = 10 },
                new Client { ClientName = "Петров Петр", Tovars = "Молоко", Count = 5 }
            };

            // Устанавливаем DataContext для страницы
            this.DataContext = this;
        }
    }

    public class Client
    {
        public string ClientName { get; set; }
        public string Tovars { get; set; }
        public int Count { get; set; }
    }
}
