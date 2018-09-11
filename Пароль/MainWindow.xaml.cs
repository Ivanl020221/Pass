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
using System.Text.RegularExpressions;
using System.IO;


namespace Пароль
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           

        }
        public String Pass,Log;
   
        
        Методы c = new Методы();
        //Метод выводящий сгенериррованный пароль.
        public void Вывод_Сгенерированного_пароля(object sender, RoutedEventArgs e)
        {
            Log = Логин.Text;
           Pass= c.генерация_пароля();
            Ваш_пароль.Text = Pass;
           Pass = c.форматирование_пароля(Pass);
            Структурированый_пароль.Text = Pass;
            Колличество_Строк.Text = Pass.Length.ToString();
            Pass = Pass.Remove(0);
           // string testa = string.Format(@"pack://application:,,,/test/{0}","bf.jpg");

            MessageBox.Show(DateTime.Now.ToString());
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            testsa.Navigate(new Uri("Передача_данных.xaml", UriKind.Relative));
            test.Source = new BitmapImage(new Uri(@"Image526057024.png", UriKind.Relative));
            Microsoft.Win32.OpenFileDialog openFile = new Microsoft.Win32.OpenFileDialog();
            MessageBox.Show(openFile.FileName.ToString());
            openFile.ShowDialog();
           // MessageBox.Show(openFile.FileName);
            Random r = new Random();
            string a = AppDomain.CurrentDomain.BaseDirectory;

          //  MessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory);
           // string path = ((BitmapImage)test.Source).UriSource.AbsolutePath;
           // MessageBox.Show(test.Source.ToString());
           
           File.Copy(openFile.FileName, a.Replace(@"bin\Debug\",@"test\") + r.Next() + ".png");
           
            

        }
        //Проверка пароля и его форматирование.
        private void Проверка_пароля(object sender, RoutedEventArgs e)
        { 
            Pass = Пароль.Text;
           if(c.Нижний_регистр(Pass)== true &&c.Верхний_регистр(Pass) == true)
            {
                MessageBox.Show("");
            }
           
            Pass = c.форматирование_пароля(Pass);
            Ваш_пароль.Text = Пароль.Text;
            if(Пароль.Text.Length != 0)
            Пароль.Text = Пароль.Text.Remove(0);
            Структурированый_пароль.Text = Pass;
            Колличество_Строк.Text = Pass.Length.ToString();
            Pass = Pass.Remove(0);
        }
    }
}
