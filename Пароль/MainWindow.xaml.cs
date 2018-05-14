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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       public String Pass;
   
        
        Методы c = new Методы();
        //Метод выводящий сгенериррованный пароль.
        public void Вывод_Сгенерированного_пароля(object sender, RoutedEventArgs e)
        {
          
          
           Pass= c.генерация_пароля();
            Ваш_пароль.Text = Pass;
           Pass = c.форматирование_пароля(Pass);
            Структурированый_пароль.Text = Pass;
            Колличество_Строк.Text = Pass.Length.ToString();
            Pass = Pass.Remove(0);
         
          
        }
        //Проверка пароля и его форматирование.
        private void Проверка_пароля(object sender, RoutedEventArgs e)
        { 
            Pass = Пароль.Text;
           Pass = c.форматирование_пароля(Pass);
            Ваш_пароль.Text = Пароль.Text;
            if(Пароль.Text.Length != 0)
            Пароль.Text = Пароль.Text.Remove(0);
            Структурированый_пароль.Text = Pass;
            Колличество_Строк.Text = Pass.Length.ToString();
        }
    }
}
