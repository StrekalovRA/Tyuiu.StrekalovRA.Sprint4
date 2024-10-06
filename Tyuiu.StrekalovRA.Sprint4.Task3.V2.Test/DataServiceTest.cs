using Tyuiu.StrekalovRA.Sprint4.Task3.V2.Lib;

namespace Tyuiu.StrekalovRA.Sprint4.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            int[,] A = new int[3, 5] {
                { 3, 8, 8, 3, 5 }, { 5, 7, 5, 4, 4 }, { 8, 8, 3, 7, 6 }
            };
            var R = DS.Calculate(A);
            Assert.AreEqual(R, 8);
        }
    }
}