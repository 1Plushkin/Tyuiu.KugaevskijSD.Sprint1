using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KugaevskijSD.Sprint1.Task1.V18.Test;
namespace Tyuiu.KugaevskijSD.Sprint1.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.4;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-0.6, res);
        }
    }
}