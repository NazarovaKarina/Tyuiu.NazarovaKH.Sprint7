using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Tyuiu.NazarovaKH.Sprint7.Project.V1.Lib
{
    public class DataService
    {
        public int GetMaxValue(int[] array)
        {
            return array.Max();
        }
        public int GetMinValue(int[] array)
        {
            return array.Min();
        }
        public double GetAvgValue(int[] array)
        {
            double res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                res += array[i];
            }
            return Math.Round(res / array.Length - 1, 3);
        }
    }
}
