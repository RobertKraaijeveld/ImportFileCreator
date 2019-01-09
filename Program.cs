using System;
using System.Linq;

namespace ImportFileCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfDays = 7;
      	    
            int[] imos = new int[35];
            for(int i = 0; i < imos.Length; i++)
            {
		        imos[i] = i + 1;
            }

            string[] sensorNames = Enum.GetNames(typeof(ESensor)).ToArray(); // 151 sensors
            ImportFileCreator.CreateFiles(amountOfDays, imos, sensorNames);
        }
    }
}
