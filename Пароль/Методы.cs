using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пароль
{
   public class Методы
    {  //Масив данных для случайной генерации пароля|замены запрещенных символов.
        Char[] c = new Char[] { '{', '}', '#', '_', '*', '+', '-', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        //Метод генеринирующий пароль.
        public string генерация_пароля()
        {
            string Pass = null;
            Random r = new Random();
            for (int I = 1; I < 30; I++)
            {
                int R1 = r.Next(0, 16);
                Pass = Pass + c[R1];
            }
            int rrr = r.Next(0, 29);
            Pass = Pass.Remove(rrr);
            return (Pass);
           
        }
        //Метод форматирующий пароль.
        public string форматирование_пароля(string Pass)
        {
            int i2 = 7;
            for (int I = 0; I < 7; I++, i2++)
            {
                Pass = Pass.Replace(c[I], c[i2]);
            }
            if (Pass.Length <= 8)
            {
                for (int i = 0; Pass.Length < 8; i++)
                {
                    Pass = Pass + '0';
                }
            }
            if (Pass.Length > 20)
            {
                Pass = Pass.Remove(20);
            }
            return (Pass);
        }
    }
}
