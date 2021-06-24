using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetClips.Logic
{
    public static class DataController
    {
        public static List<int> GetAgeDataSource()
        {
            var AgeList = new List<int>();
            AgeList.AddRange(Enumerable.Range(18, 28));

            return AgeList;
        }

        public static List<string> GetPreferredFootDataSource()
        {
            return new List<string> { "Right", "Left" };
        }

        public static List<string> GetPlayerPositionsDataSource()
        {
            return new List<string> { "GK", "CB", "LCB", "RCB", "LB", "RB", "LWB", "RWB", "CDM", "LDM", "RDM", "CM", "LCM", "RCM", "LM", "RM", "CAM", "LAM", "RAM", "LW", "RW", "CF", "LCF", "RCF", "ST" };
        }

        public static List<string> GetPlayStyleDataSource()
        {
            return new List<string> { "Classic", "Tiki-Taka", "Counter-Attack", "Park-The-Bus", "Long-Ball", "High-Press" };
        }

        public static void ExportData(DataModel dataModel)
        {
            string Output = string.Empty;

            foreach (var property in dataModel.GetType().GetProperties())
            {
                Output += dataModel.GetType().GetProperty(property.Name)?.GetValue(dataModel, null) + "\n";
            }

            File.WriteAllText("Output.txt", Output);
        }
    }
}
