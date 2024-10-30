using Tyuiu.AnishchenkoVA.Sprint2.Task4.V30.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint2.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double z = 7;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 5;
            double z = 7;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}