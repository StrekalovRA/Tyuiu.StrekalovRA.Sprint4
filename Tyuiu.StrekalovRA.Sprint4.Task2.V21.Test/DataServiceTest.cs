using Tyuiu.StrekalovRA.Sprint4.Task2.V21.Lib;

namespace Tyuiu.StrekalovRA.Sprint4.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            var R = DS.Calculate(new int[] { 1, 2, 6, 4, 7, 4, 3 });
            Assert.AreEqual(R, 192);
        }
    }
}