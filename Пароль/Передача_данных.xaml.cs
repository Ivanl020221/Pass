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

namespace Пароль
{
    /// <summary>
    /// Логика взаимодействия для Передача_данных.xaml
    /// </summary>\
    
    public partial class Передача_данных : Page
    {
        public Передача_данных()
        {
            InitializeComponent();
        }

        private void Передать_данные(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.Структурированый_пароль.Text = Testing.Text;
             NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(new Uri("График.xaml", UriKind.Relative));
        }
    }
}
