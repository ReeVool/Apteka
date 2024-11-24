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
    /// Логика взаимодействия для Contrs_Spis.xaml
    /// </summary>
    public partial class Contrs_Spis : Page
    {
        public Contrs_Spis()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            сотрудникиDataGrid.ItemsSource = AppData.db.Сотрудники.ToList();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите удалить запись?", "Подтверждение удаления",
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                var currentSotr = сотрудникиDataGrid.SelectedItem as Сотрудники;

                AppData.db.Сотрудники.Remove(currentSotr);
                AppData.db.SaveChanges();

                сотрудникиDataGrid.ItemsSource = AppData.db.Сотрудники.ToList();

                MessageBox.Show("Контрагент удален");
            }
        }
    }
}
