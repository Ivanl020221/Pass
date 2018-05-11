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
    public class форматирование_пароляTest
    {
        [TestMethod()]
        public void Pass_PassLengh_PassLenghtNotMore20AndMore8()
        { 
            
            Методы c = new Методы();

            String x = "{}{{{}**#0302";

            string actual = c.форматирование_пароля(x);

            Assert.IsTrue(actual.Length<20&&actual.Length>8);
        }
    }
}