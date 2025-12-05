using Tyuiu.BatTI.Sprint6.Task0.V9.Lib;

namespace Tyuiu.BatTI.Sprint6.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-2.556, ds.Calculate(3));
        }
    }
}
