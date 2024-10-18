using Tyuiu.AnishchenkoVA.Sprint2.Task3.V11.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint2.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double kk = 1.778;
            Assert.AreEqual(kk, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double kk = 0.750;
            Assert.AreEqual(kk, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double kk = 0.500;
            Assert.AreEqual(kk, res);
        }

        [TestMethod]
        public void ValidCondition5()
        {
            DataService ds = new DataService();
            double x = -20;
            double res = ds.Calculate(x);
            double kk = -219.950;
            Assert.AreEqual(kk, res);
        }
    }
}