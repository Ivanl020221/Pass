using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Пароль
{
    class Class_LF
    {

        public void Show(string a)
        {
            MessageBox.Show(a);
        }
        public string SumY(double k1, double b1, double k2, double b2)
        {
            string sum;
            double K, B;
            K = k1 + k2;
            B = b1 + b2;
            if(B>0)
            {
              sum = "Y" + "=" + K.ToString() + "x"+"+" +B ;
            }
             else
            {
                sum = "Y" + "=" + K.ToString() + "x" + B;
            }
               
            return (sum);
        }
            
            
    }

}
