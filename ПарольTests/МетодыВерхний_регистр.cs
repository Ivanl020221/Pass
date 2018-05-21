using Microsoft.VisualStudio.TestTools.UnitTesting;
using Пароль;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пароль.Tests
{
    [TestClass()]
    public class МетодыВерхний_регистр
    {
        [TestMethod()]
        public void Верхний_регистрВерхний_регистр_ввод_Вы_falce()
        { Методы методы = new Методы();
            string extended = "asddasdasdsa";
            bool actual = методы.Верхний_регистр(extended);
            Assert.AreEqual(extended, actual);
        }
    }
}