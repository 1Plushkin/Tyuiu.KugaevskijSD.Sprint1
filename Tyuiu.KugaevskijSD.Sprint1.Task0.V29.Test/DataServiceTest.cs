namespace Tyuiu.KugaevskijSD.Sprint1.Task.V29.Test;
using Tyuiu.KugaevskijSD.Sprint1.Task0.V29.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        var res = ds.Calculate();
        Assert.AreEqual(2, res);

    }
}