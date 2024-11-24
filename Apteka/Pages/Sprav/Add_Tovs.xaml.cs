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
    /// Логика взаимодействия для Add_Tovs.xaml
    /// </summary>
    public partial class Add_Tovs : Page
    {
        public Add_Tovs()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            Товары tovar = new Товары();

            tovar.Код_производителя = Convert.ToInt32(CodProis.Text);
            tovar.Производитель = NameProis.Text;
            tovar.Наименование = NameTov.Text;
            tovar.Артикул = Convert.ToInt32(Artic.Text);
            tovar.Тип = TypeTov.Text;
            tovar.Стоимость = Convert.ToDecimal(Price.Text);

            // сохранение
            AppData.db.Товары.Add(tovar);
            AppData.db.SaveChanges();
            MessageBox.Show("Товар успешно добавлен!", "Уведомление", 
                MessageBoxButton.OK, MessageBoxImage.Information);


            // очистка значений
            CodProis.Clear();
            NameProis.Clear();
            NameTov.Clear();
            Artic.Clear();
            TypeTov.Clear();
            Price.Clear();
        }
    }
}
