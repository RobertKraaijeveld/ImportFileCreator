using System;
using System.Linq;
using System.IO;

namespace PrototypeStressTester
{
    /// <summary>
    /// Creates fake import files for use in (stress) testing the import functionality of the Thesis prototype.
    /// Filenames are like <imo>_<year><month><day>_03000.csv, for example 1111111_20180101_03000.csv
    /// Each file contains 1440 rows, one for each minute of the day.
    /// Columns are: ts,sensor1, ... sensor151. The ts value is the timestamp for the minute, in human-readable format.
    /// </summary>
    public static class ImportFileCreator
    {
        /// <summary>
        /// Creates the <amount> of fake import files requested and returns their filenames.
        /// Each sensor-value is a randomly generated double and the names of the sensors are obviously meaningless.
        /// </summary>
        public static void CreateFiles(int amount, int[] imos, string[] sensorNames)
        {
            if(amount > 365 * 10) throw new Exception("No more than 10 years, please.");

            string projectDirectory = GetProjectDirectory();
            
            int rowAmount = 1441; // 1440 minutes in a day + header 

            foreach(var imo in imos)
            {
                for(int i = 0; i < amount - 1; i++)
                {
                    var fileDate = new DateTime(2000, 1, 1);
                    var fileName = $"{imo}_{fileDate.Year}{StringifyMonthOrYearInt(fileDate.Month)}{StringifyMonthOrYearInt(fileDate.Day)}_03000.csv";

                    using(var newFileStr = File.CreateText($"{projectDirectory}\\Output\\{fileName}"))
                    {
                        for(int j = 0; j < rowAmount; j++)
                        {
                            string newLine = "";
                            
                            if(j == 0) 
                            {
                                newLine = string.Join(',', sensorNames);
                            }
                            else
                            {
                                var randomSensorValues = GetRandomValues(sensorNames.Length - 1); // -1 because timestamp (ts) sensor value is not randomly generated
                                var randomSensorValuesAsStr = string.Join(',', randomSensorValues.Select(v => v.ToString()));

                                newLine = $"{fileDate},{randomSensorValuesAsStr}";
                            }

                            newFileStr.WriteLine(newLine);
                            fileDate = fileDate.AddMinutes(1);
                        }
                    }

                    fileDate = fileDate.AddDays(1);
                }
            }
        }

        private static string GetProjectDirectory()
        {
            return Directory.GetCurrentDirectory();
        }

        private static string StringifyMonthOrYearInt(int monthOrYear)
        {
            return monthOrYear >= 10 ? monthOrYear.ToString()
                                     : $"0{monthOrYear.ToString()}";
        }

        private static double[] GetRandomValues(int amount, int min = 0, int max = 500)
        {
            var random = new Random();

            double[] ret = new double[amount];
            for(int i = 0; i < amount; i++)
            {
                ret[i] = random.NextDouble() * (max - min) + min;
            }
            return ret;
        }
    }
}
