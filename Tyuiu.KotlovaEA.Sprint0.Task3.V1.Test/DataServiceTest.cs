using Tyuiu.KotlovaEA.Sprint0.Task3.V1.Lib;
namespace Tyuiu.KotlovaEA.Sprint0.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
