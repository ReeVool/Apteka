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
    /// Логика взаимодействия для Ot_Type.xaml
    /// </summary>
    public partial class Ot_Type : Page
    {
        public Ot_Type()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            счет_фактурыDataGrid.ItemsSource = AppData.db.Счет_фактуры.ToList();
        }
    }
}
