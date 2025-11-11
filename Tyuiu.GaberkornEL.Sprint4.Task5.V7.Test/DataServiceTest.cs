using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GaberkornEL.Sprint4.Task5.V7.Lib;

namespace Tyuiu.GaberkornEL.Sprint4.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5]
            {
                { -1, 2, -3, 4, -5 },
                { 6, -7, 8, -9, 0 },
                { -2, 3, -4, 5, -6 },
                { 7, -8, 9, 0, -1 },
                { -3, 4, -5, 6, -7 }
            };

            int result = ds.Calculate(array);
            int wait = 12;

            Assert.AreEqual(wait, result);
        }
    }
}