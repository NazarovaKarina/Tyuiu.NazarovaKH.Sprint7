using System.IO;
using Tyuiu.NazarovaKH.Sprint7.Project.V1.Lib;
namespace Tyuiu.NazarovaKH.Sprint7.Project.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        string filePath = @"C:\ \";
        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;
        }
        [TestMethod]
        public void CheckMaxPower()
        {
            double wait = 200;
            double res = ds.MaxPower(LoadFromFileData(filePath));
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckMinPower()
        {
            double wait = 150;
            double res = ds.MinPower(LoadFromFileData(filePath));
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckAveragePower()
        {
            double wait = 175;
            double res = ds.AveragePower(LoadFromFileData(filePath));
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckCountCars()
        {
            double res = 1;
            double wait = ds.CountCars(LoadFromFileData(filePath), "Toyota");
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckCountMechanicsByQual()
        {
            double res = 1;
            double wait = ds.CountMechanicsByQual(LoadFromFileData(filePath), "Автомеханик");
            Assert.AreEqual(wait, res);
        }
    }
}