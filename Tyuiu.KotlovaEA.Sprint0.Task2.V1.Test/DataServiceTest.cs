using Tyuiu.KotlovaEA.Sprint0.Task2.V1.Lib;
namespace Tyuiu.KotlovaEA.Sprint0.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Елизавета";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Елизавета", res);
        }
    }
}
