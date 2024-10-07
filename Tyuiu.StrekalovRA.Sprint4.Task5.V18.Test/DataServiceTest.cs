using Tyuiu.StrekalovRA.Sprint4.Task5.V18.Lib;

namespace Tyuiu.StrekalovRA.Sprint4.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            var R = DS.Calculate(new int[3, 3] { { 4, 3, -9 }, { 8, 4, 0 }, { -1, -2, 4 } });
            CollectionAssert.AreEqual(R, new int[3, 3] { { 4, 3, 0}, { 8, 4, 0}, { 0, 0, 4} });
        }
    }
}