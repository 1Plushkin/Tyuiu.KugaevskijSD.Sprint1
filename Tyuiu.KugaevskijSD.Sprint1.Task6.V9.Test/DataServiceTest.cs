namespace Tyuiu.KugaevskijSD.Sprint1.Task6.V9.Test;

using System;
using Tyuiu.KugaevskijSD.Sprint1.Task6.V9.Lib;

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Hello world";
            DataService ds = new DataService();
            string res = MoveLetterToStart(strTest);
            string wait = "";
            Assert.AreEqual(wait, res);

        }

    private string MoveLetterToStart(string strTest)
    {
        throw new NotImplementedException();
    }
}