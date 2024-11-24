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

namespace Apteka.Pages.Contr
{
    /// <summary>
    /// Логика взаимодействия для Add_Contrs.xaml
    /// </summary>
    public partial class Add_Contrs : Page
    {
        public Add_Contrs()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            Сотрудники sotr = new Сотрудники();

            sotr.Фамилия = Surname.Text;
            sotr.Имя_и_отчество = Name.Text;
            sotr.Должность = Role.Text;
            sotr.Дата_рождения = Convert.ToDateTime(BirhtDay.Text);
            sotr.Дата_регистрации = Convert.ToDateTime(DateReg.Text);

            // сохранение
            AppData.db.Сотрудники.Add(sotr);
            AppData.db.SaveChanges();
            MessageBox.Show("Контрагент успешно добавлен!", "Уведомление",
                MessageBoxButton.OK, MessageBoxImage.Information);


            // очистка значений
            Surname.Clear();
            Name.Clear();
            Role.Clear();
        }
    }
}
