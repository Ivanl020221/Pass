using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ПарольTests
{
    [TestClass]
    public class Пароль_не_равен_логину
    {
        [TestMethod]
        public void ПарольиЛогин_Проверка_ПеСовпадают()
        { Пароль.MainWindow mainWindow = new Пароль.MainWindow();
            mainWindow.Pass = "Pass";
            string extended_1 = mainWindow.Pass;
            mainWindow.Log = "Log";
            string extended_2 = mainWindow.Log;

            Assert.IsTrue(extended_1 != extended_2);
        }
    }
}
