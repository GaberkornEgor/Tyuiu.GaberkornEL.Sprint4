using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GaberkornEL.Sprint4.Task0.V3.Lib
{
    public class DataService : ISprint4Task0V3
    {
        public int GetMultOddArrEl(int[] array)
        {
            int res = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    res = (res + 1) * array[i];
                }
                else { return res; }
            }
            return res;

        }
    }
}
