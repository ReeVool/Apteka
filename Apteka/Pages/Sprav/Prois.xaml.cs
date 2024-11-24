using Apteka.Model;
using static Apteka.Model.Производители;
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
using System.Diagnostics;

namespace Apteka
{
    /// <summary>
    /// Логика взаимодействия для Prois.xaml
    /// </summary>
    public partial class Prois : Page
    {
        public Prois()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Производители prois = new Производители();

            prois.Наименование = наименованиеTextBox.Text;
            prois.Адрес = адресTextBox.Text;
            prois.Телефон = телефонTextBox.Text;
            prois.Email = emailTextBox.Text;

            // добавление и сохранение
            AppData.db.Производители.Add(prois);
            AppData.db.SaveChanges();
            MessageBox.Show("Производитель успешно добавлен!", "Уведомление",
                MessageBoxButton.OK, MessageBoxImage.Information);
            
            производителиDataGrid.ItemsSource = AppData.db.Производители.ToList();


            // очистка значений
            наименованиеTextBox.Clear();
            адресTextBox.Clear();
            телефонTextBox.Clear();
            emailTextBox.Clear();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            производителиDataGrid.ItemsSource = AppData.db.Производители.ToList();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите удалить запись?", "Подтверждение удаления",
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                var currentProis = производителиDataGrid.SelectedItem as Производители;

                AppData.db.Производители.Remove(currentProis);
                AppData.db.SaveChanges();

                производителиDataGrid.ItemsSource = AppData.db.Производители.ToList();

                MessageBox.Show("Производитель удален");
            }
        }
    }
}
