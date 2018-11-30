using System;
using System.Collections.Generic;
using System.Linq;
using ThesisPrototype;

namespace PrototypeStressTester
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new PrototypeContext())
            {
                int[] imos = ctx.Ships.Select(x => x.ImoNumber).ToArray();
                string[] sensorNames = Enum.GetNames(typeof(ESensor)).ToArray();

                ImportFileCreator.CreateFiles(1, imos, sensorNames);
            }

        }
    }
}
