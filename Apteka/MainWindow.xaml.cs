using Apteka.Pages.Contr;
using Apteka.Pages.Prods;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // страницы
        MainPage mainPage = new MainPage();

        // справочники
        Spis_Tov spis_Tov = new Spis_Tov();
        Group_Tov group_Tov = new Group_Tov();
        Prois prois = new Prois();
        Add_Tovs add_Tovs = new Add_Tovs();

        // продажи
        Ychet ychet = new Ychet();
        Schet_Fact schet_Fact = new Schet_Fact();
        Ot_Date ot_Date = new Ot_Date();
        Ot_Type ot_Type = new Ot_Type();
        Ot_Clients ot_Clients = new Ot_Clients();

        // контрагенты
        Contrs_Spis contrs_Spis = new Contrs_Spis();
        Add_Contrs add_Contrs = new Add_Contrs();
        Add_Persn add_Persn = new Add_Persn();
        Spis_Persn spis_Persn = new Spis_Persn();

        public MainWindow()
        {
            InitializeComponent();

            // начальное окна
            ContentFrame.Content = mainPage;
        }

        // кнопка "развернуть все"
        private void ExpAll_Click(object sender, RoutedEventArgs e)
        {
            Contragents.IsExpanded = true;
            Prods.IsExpanded = true;
            Sprav.IsExpanded = true;
        }

        // кнопка "свернуть все"
        private void UnexpAll_Click(object sender, RoutedEventArgs e)
        {
            Contragents.IsExpanded = false;
            Prods.IsExpanded = false;
            Sprav.IsExpanded = false;
        }


        // кнопки сбоку для открытия страниц
        // возврат на главное окно
        private void OnMain_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = mainPage;
        }

        // справочники
        private void SpravSpis_Selected(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = spis_Tov;
        }

        private void SpravGroups_Selected(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = group_Tov;
        }

        private void SpravProis_Selected(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = prois;
        }

        private void SpravAdd_Selected(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = add_Tovs;
        }


        // контрагенты
        private void ContrSpCon_Selected(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = contrs_Spis;
        }

        private void ContrAdd_Selected(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = add_Contrs;
        }

        private void ContrAddPerson_Selected(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = add_Persn;
        }

        private void ContrSpPerson_Selected(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = spis_Persn;
        }

        // продажи
        private void ProdsYch_Selected(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = ychet;
        }

        private void ProdsSchF_Selected(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = schet_Fact;
        }

        private void ProdsOtDate_Selected(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = ot_Date;
        }

        private void ProdsOtType_Selected(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = ot_Type;
        }

        private void ProdsOtClient_Selected(object sender, RoutedEventArgs e)
        {
            ContentFrame.Content = ot_Clients;
        }
    }
}