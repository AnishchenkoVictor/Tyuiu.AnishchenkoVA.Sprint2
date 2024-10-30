using Tyuiu.AnishchenkoVA.Sprint2.Task6.V6.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 13;
            int y = 1;
            string z = "Король пик";
            string res = ds.FindCardNameAndValue(x, y);
            Assert.AreEqual(z, res);
        }
    }
}