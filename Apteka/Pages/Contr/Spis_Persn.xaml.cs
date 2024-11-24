using Apteka.Model;
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

namespace Apteka.Pages.Contr
{
    /// <summary>
    /// Логика взаимодействия для Spis_Persn.xaml
    /// </summary>
    public partial class Spis_Persn : Page
    {
        public Spis_Persn()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            клиентыDataGrid.ItemsSource = AppData.db.Клиенты.ToList();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите удалить запись?", "Подтверждение удаления",
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                var currentPer = клиентыDataGrid.SelectedItem as Клиенты;

                AppData.db.Клиенты.Remove(currentPer);
                AppData.db.SaveChanges();

                клиентыDataGrid.ItemsSource = AppData.db.Клиенты.ToList();

                MessageBox.Show("Клиент удален");
            }
        }
    }
}
