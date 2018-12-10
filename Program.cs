using System;
using System.Linq;
using ThesisPrototype.DatabaseApis;
using ThesisPrototype.Enums;

namespace PrototypeStressTester
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new PrototypeContext())
            {
                int amountOfDays = 365 * 3; // 3 years
                int[] imos = ctx.Ships.Select(x => x.ImoNumber).ToArray(); // all ships (35 of them, to be exact)
                string[] sensorNames = Enum.GetNames(typeof(ESensor)).ToArray(); // 151 sensors

                ImportFileCreator.CreateFiles(amountOfDays, imos, sensorNames);
            }
        }
    }
}