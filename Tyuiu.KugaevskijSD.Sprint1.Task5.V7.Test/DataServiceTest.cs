namespace Tyuiu.KugaevskijSD.Sprint1.Task5.V7.Test;

using System;
using Tyuiu.KugaevskijSD.Sprint1.Task5.V7.Lib;
    [TestClass]
public class DataSeviceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        int res = ds.AngleToHoursMinutes(100);
        Assert.AreEqual(3, res);
    }
}
