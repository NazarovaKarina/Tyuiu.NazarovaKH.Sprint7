using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Tyuiu.NazarovaKH.Sprint7.Project.V1.Lib
{
    public class DataService
    {
        //поиск максимальной мощности автомобиля
        public double MaxPower(string[,] data)
        {
            double maxPower = 0;
            int powerColumnIndex = 11; //мощность авто
            for (int i = 1; i < data.GetLength(0); i++)
            {
                if (double.TryParse(data[i, powerColumnIndex], out double currentPower) && currentPower > maxPower)
                {
                    maxPower = currentPower;
                }
            }
            return maxPower;
        }
        //поиск минимальной мощности автомобиля
        public double MinPower(string[,] data)
        {
            double minPower = double.MaxValue;
            int powerColumnIndex = 11; //мощность авто
            for (int i = 1;i < data.GetLength(0); i++)
            {
                if (double.TryParse(data[i, powerColumnIndex], out double currentPower) && currentPower < minPower)
                {
                    minPower = currentPower;
                }
            }
            return minPower;
        }
        //поиск средней мощности автомобиля
        public double AveragePower(string[,] data)
        {
            double sumPower = 0;
            int count = 0;
            int powerColumnIndex = 11;
            for (int i = 1; i < data.GetLength(0); i++)
            {
                if (double.TryParse(data[i, powerColumnIndex],out double currentPower))
                {
                    sumPower += currentPower;
                    count++;
                }
            }
            if (count > 0)
            {
                return Math.Round(sumPower / count, 2);
            }
            return 0;
        }
        // кол-во автомобилей определенной марки
        public int CountCars(string[,] data, string carBrand)
        {
            int count = 0;
            int carBrandColumnIndex = 10; //индекст столбца "марка авто"
            for (int i = 1; i < data.GetLength(0); i++)
            {
                if (data[i, carBrandColumnIndex].Equals(carBrand, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
            return count;
        }
        //список квалификаций механиков
        public string[] GetMechaniQuals(string[,] data)
        {
            var uniqueQuals = new System.Collections.Generic.HashSet<string>();
            int qualColumnIndex = 8;
            for (int i = 1;i < data.GetLength(0); i++)
            {
                uniqueQuals.Add(data[i, qualColumnIndex]);
            }
            return uniqueQuals.ToArray();
        }
        // кол-во механиков с определенной квалификацией
        public int CountMechanicsByQual(string[,] data, string qual)
        {
            int count = 0;
            int qualColumnIndex = 8;
            for (int i = 1; i < data.GetLength(0); i++)
            {
                if (data[i, qualColumnIndex].Equals(qual, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
