using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GaberkornEL.Sprint4.Task0.V3.Lib;
namespace Tyuiu.GaberkornEL.Sprint4.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsArray = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
            int res = ds.GetMultOddArrEl(numsArray);
            int wait = 945;
            Assert.AreEqual(wait, res);
        }
    }
}