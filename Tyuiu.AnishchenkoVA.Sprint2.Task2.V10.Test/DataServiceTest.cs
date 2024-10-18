using Tyuiu.AnishchenkoVA.Sprint2.Task2.V10.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint2.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool kk = true;
            Assert.AreEqual(kk, res);
        }
    }
}