using Tyuiu.StrekalovRA.Sprint4.Task7.V22.Lib;

namespace Tyuiu.StrekalovRA.Sprint4.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            var R = DS.Calculate(5, 3, "695324951753684");
            Assert.AreEqual(R, 9216);
        }

        [TestMethod]

        public void TestMethod2() { 
            DataService DS = new DataService();
            var S = DS.Calculate(4, 4, "2149239419381133");
            Assert.AreEqual(S, 512);
        }
    }
}