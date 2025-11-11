using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GaberkornEL.Sprint4.Task6.V22.Lib
{
    public class DataService : ISprint4Task6V22
    {
        public string[] Calculate(string[] array)
        {
            string[] result = Array.FindAll(array, x => x.Length == 4);
            return result;
        }
    }
}