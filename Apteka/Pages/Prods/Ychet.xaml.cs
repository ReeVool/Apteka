using Apteka.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для Ychet.xaml
    /// </summary>
    public partial class Ychet : Page
    {
        public Ychet()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var sotr = new Счет_фактуры();

            sotr.Код_клиента = Convert.ToInt32(CodClient.Text);
            sotr.Код_сотрудника = Convert.ToInt32(CodSotr.Text);
            sotr.Клиент = NameClient.Text;
            sotr.Товар = Tovar.Text;
            sotr.Количество = Convert.ToInt32(Kol.Text);
            sotr.Дата = Convert.ToDateTime(Date.Text);

            AppData.db.Счет_фактуры.Add(sotr);
            AppData.db.SaveChanges();
            MessageBox.Show("Контрагент успешно добавлен!", "Уведомление",
                MessageBoxButton.OK, MessageBoxImage.Information);

            // очистка значений
            CodClient.Clear();
            CodSotr.Clear();
            NameClient.Clear();
            Tovar.Clear();
            Kol.Clear();
        }
    }
}
