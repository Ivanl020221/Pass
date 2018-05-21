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
    public class МетодыНижний_регистр
    {
        [TestMethod()]
        public void Нижний_регистрНижний_регистр_ввод_Вы_true()
        { Методы c = new Методы();
            string test = "Assad";
            bool actual = c.Нижний_регистр(test);
            Assert.AreEqual(actual, true);
        }
    }
}