using Apteka.Model;
using static Apteka.Model.Товары;
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

namespace Apteka
{
    /// <summary>
    /// Логика взаимодействия для Spis_Tov.xaml
    /// </summary>
    public partial class Spis_Tov : Page
    {
        public Spis_Tov()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            товарыDataGrid.ItemsSource = AppData.db.Товары.ToList();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите удалить запись?", "Подтверждение удаления",
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                var currentTov = товарыDataGrid.SelectedItem as Товары;

                AppData.db.Товары.Remove(currentTov);
                AppData.db.SaveChanges();

                товарыDataGrid.ItemsSource = AppData.db.Товары.ToList();

                MessageBox.Show("Товар удален");
            }
        }
    }
}
