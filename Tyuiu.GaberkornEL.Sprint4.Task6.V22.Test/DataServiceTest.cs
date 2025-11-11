using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GaberkornEL.Sprint4.Task6.V22.Lib;

namespace Tyuiu.GaberkornEL.Sprint4.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] word = new string[] { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };

            string[] result = ds.Calculate(word);
            int count = result.Length;

            int wait = 2;

            Assert.AreEqual(wait, count);
        }
    }
}