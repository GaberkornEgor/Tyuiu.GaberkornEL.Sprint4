using Tyuiu.GaberkornEL.Sprint4.Task3.V13.Lib;

namespace Tyuiu.GaberkornEL.Sprint4.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Test()
        {
            int[,] array = {{ 4, 7, 4, 2, 1 },{ 6, 7, 3, 6, 5 }, { 6, 5, 3, 3, 5 },{ 4, 4, 6, 4, 7 },{ 2, 1, 2, 3, 4 }
        };
            DataService dataService = new DataService();
            int sumtip = 15;

            int actualsum = dataService.Calculate(array);

            Assert.AreEqual(sumtip, actualsum);
        }
    }
}