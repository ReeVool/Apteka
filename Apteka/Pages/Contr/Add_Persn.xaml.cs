using Apteka.Model;
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

namespace Apteka.Pages.Contr
{
    /// <summary>
    /// Логика взаимодействия для Add_Persn.xaml
    /// </summary>
    public partial class Add_Persn : Page
    {
        public Add_Persn()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            Клиенты clients = new Клиенты();

            clients.Код_товара = Convert.ToInt32(CodTov.Text);
            clients.Код_производителя = Convert.ToInt32(CodProis.Text);
            clients.Наименование = NameTov.Text;
            clients.Адрес = Adres.Text;
            clients.Банк = Bank.Text;
            clients.Телефон = Tel.Text;
            clients.Контактное_лицо = Ebalo.Text;
            clients.Email = Email.Text;

            // сохранение
            AppData.db.Клиенты.Add(clients);
            AppData.db.SaveChanges();
            MessageBox.Show("Контрагент успешно добавлен!", "Уведомление",
                MessageBoxButton.OK, MessageBoxImage.Information);


            // очистка значений
            CodTov.Clear();
            CodProis.Clear();
            NameTov.Clear();
            Adres.Clear(); 
            Bank.Clear();
            Tel.Clear();
            Ebalo.Clear();
            Email.Clear();
        }
    }
}
