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
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Пароль
{
    /// <summary>
    /// Логика взаимодействия для График.xaml
    /// </summary>
    public partial class График : Page
    {
       
        public График()
        {
            InitializeComponent();

            Chart.ChartAreas.Add(new ChartArea("Default"));
            Chart.Series.Add(new Series("Series1"));
            Chart.Series["Series1"].ChartArea = "Default";
            Chart.Series["Series1"].ChartType = SeriesChartType.Line;
        }
      
       public void Вывод(string a, int b)
        {
            
        }
        
        public void Chart_Click(object sender, EventArgs e)
        {
            //MainWindow sda = new MainWindow();

            MainWindow a = (MainWindow)Window.GetWindow(this);
           //Chart.Series["Series1"].Points.DataBindXY(a.x, a.y);

            Chart.Series["Series1"].Points.AddXY(a.Pass, a.Pass.Length);
        }
    }
}
