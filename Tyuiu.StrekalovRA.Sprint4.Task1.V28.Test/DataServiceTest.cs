using Tyuiu.StrekalovRA.Sprint4.Task1.V28.Lib;

namespace Tyuiu.StrekalovRA.Sprint4.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            var R = DS.Calculate(new int[] { 2, 4, 4, 5, 3, 4, 4, 6, 2, 4, 5, 5, 4, 4 });
            Assert.AreEqual(R, 375);
        }
    }
}