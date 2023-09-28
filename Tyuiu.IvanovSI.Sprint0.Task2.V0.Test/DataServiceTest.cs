using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint0.Task2.V0.Lib;
namespace Tyuiu.IvanovSI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessegeValid()
        {
            var name = "Семён";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Семён", res);
        }
    }
}
