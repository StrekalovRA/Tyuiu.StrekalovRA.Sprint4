using Tyuiu.StrekalovRA.Sprint4.Task6.V29.Lib;

namespace Tyuiu.StrekalovRA.Sprint4.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            var R = DS.Calculate(new string[4] {"Весна", "Лето", "Осень", "Зима" });
            Assert.AreEqual(R, 2);
        }
    }
}