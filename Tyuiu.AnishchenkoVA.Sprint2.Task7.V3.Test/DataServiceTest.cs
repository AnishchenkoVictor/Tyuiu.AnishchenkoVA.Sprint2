using Tyuiu.AnishchenkoVA.Sprint2.Task7.V3.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint2.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0.2;
            double y = 0.4;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool z = true;

            Assert.AreEqual(z, res);
        }
    }
}