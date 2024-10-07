using Tyuiu.StrekalovRA.Sprint4.Task4.V27.Lib;

namespace Tyuiu.StrekalovRA.Sprint4.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            int[,] A = new int[5, 5] {
                { 4, 3, 9, 2, 2 },
                { 8, 4, 1, 4, 3 },
                { 3, 9, 2, 2, 5 },
                { 4, 6, 8, 5, 6 },
                { 1, 5, 2, 2, 5 }
            };

            var R = DS.Calculate(A);
            Assert.AreEqual(R, 49);
        }
    }
}