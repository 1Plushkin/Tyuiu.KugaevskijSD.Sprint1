namespace Tyuiu.KugaevskijSD.Sprint1.Task3.V2.Test;
using Tyuiu.KugaevskijSD.Sprint1.Task3.V2.Lib;

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double cen = 15.98;
            int tetr = 3;
            double cen1 = 16.999;
            int kar = 3;
            double wait = 98.937;
            var res = ds.PurchaseAmount(cen, tetr, cen1, kar);
            Assert.AreEqual(wait, res);

        }
    }
