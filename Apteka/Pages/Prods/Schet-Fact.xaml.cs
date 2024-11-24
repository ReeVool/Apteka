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

namespace Apteka.Pages.Prods
{
    /// <summary>
    /// Логика взаимодействия для Schet_Fact.xaml
    /// </summary>
    public partial class Schet_Fact : Page
    {
        public Schet_Fact()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            счет_фактурыDataGrid.ItemsSource = AppData.db.Счет_фактуры.ToList();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            // подтверждение удаления
            MessageBoxResult result = MessageBox.Show("Вы точно хотите удалить запись?", "Подтверждение удаления",
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            // проверка на подтверждение
            if (result == MessageBoxResult.Yes)
            {
                var currentScFc = счет_фактурыDataGrid.SelectedItem as Счет_фактуры;

                AppData.db.Счет_фактуры.Remove(currentScFc);
                AppData.db.SaveChanges();

                счет_фактурыDataGrid.ItemsSource = AppData.db.Счет_фактуры.ToList();

                MessageBox.Show("Счет-фактура удалена");
            }
        }
    }
}
