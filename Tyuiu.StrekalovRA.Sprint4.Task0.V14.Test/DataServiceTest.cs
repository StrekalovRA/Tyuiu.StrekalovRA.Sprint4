using Tyuiu.StrekalovRA.Sprint4.Task0.V14.Lib;

namespace Tyuiu.StrekalovRA.Sprint4.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            int[] A = new int[] { 1, 4, 2, -3, 6, 9 };
            int T = DS.GetSumOddArrEl(A);
            Assert.AreEqual(T, 7);
        }
    }
}