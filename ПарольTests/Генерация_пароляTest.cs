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
    public class Генерация_пароляTest
    {
        [TestMethod()]
        public void passLenght_geneate_moere0NotMore29()
        {
            //arange
            int min = 0;
            int max = 29;
            //act
            Методы a = new Методы();
            String actual = a.генерация_пароля();
            //assert
            Assert.IsTrue(actual.Length > min && actual.Length < max);
        }
    }
}