using System;
using System.Linq;

namespace ImportFileCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfDays = 7;
            int[] imos = new int[]{ 1, 2, 3, 4, 5 };
            string[] sensorNames = Enum.GetNames(typeof(ESensor)).ToArray(); // 151 sensors

            ImportFileCreator.CreateFiles(amountOfDays, imos, sensorNames);
        }
    }
}
