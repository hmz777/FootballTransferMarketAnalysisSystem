using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DotNetClips.Logic
{
    public class ClipsBasicController : IClipsController
    {
        #region Constructor

        public ClipsBasicController(int DataCount)
        {
            this.DataCount = DataCount;
        }

        #endregion

        #region Properties

        public int DataCount { get; set; }

        #endregion

        public void GetResult()
        {
            throw new NotImplementedException();
        }

        public void InitController()
        {
            throw new NotImplementedException();
        }

        public void SendParameters()
        {
            throw new NotImplementedException();
        }

        public string EscapeBadChars(string Value)
        {
            if (Value.Contains(",") || Value.Contains("&") || Value.Contains(")") || Value.Contains("("))
            {
                Regex pattern = new Regex("[&,)(]");
                return pattern.Replace(Value, "");
            }

            return Value;
        }

        public async Task<string> EnsureClipsBatchFileCreated(string ClipsFilePath, DataModel dataModel)
        {
            await Task.Run(() =>
             {
                 var CLP = new StringBuilder();

                 //Open player deftemplate
                 CLP.Append("(deftemplate player\n");
                 foreach (var property in typeof(PlayerModel).GetProperties())
                 {
                     //The multislot attribute is a dummy attribute to differentiate between slots fields and multislot fields
                     if (!Attribute.IsDefined(property, typeof(MultislotAttribute)))
                     {
                         CLP.Append($"(slot {property.Name})\n");
                     }
                     else
                     {
                         CLP.Append($"(multislot {property.Name})\n");
                     }
                 }
                 CLP.Append(")\n\n");
                 //Close player deftemplate

                 //Open average_scores deftemplate
                 CLP.Append("(deftemplate average_scores\n");
                 foreach (var property in typeof(PlayerModel).GetProperties())
                 {
                     if (Attribute.IsDefined(property, typeof(AvgValueAttribute)))
                     {
                         CLP.Append($"(slot avg_{property.Name})\n");
                     }
                 }
                 CLP.Append(")\n\n");
                 //Close average_scores deftemplate

                 //Open deffacts (players)
                 CLP.Append("(deffacts players\n");
                 using (var reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("DotNetClips.Resources.players_21.csv")))
                 using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                 {
                     var Players = csv.GetRecords<PlayerModel>().Take(DataCount);
                     string player = null;
                     string PropVal = null;

                     foreach (var Record in Players)
                     {
                         player = "(player ";
                         foreach (var property in typeof(PlayerModel).GetProperties())
                         {
                             PropVal = string.IsNullOrEmpty((string)property.GetValue(Record)) ? "none" : (string)property.GetValue(Record);

                             PropVal = EscapeBadChars(PropVal);

                             player += $"({property.Name} {PropVal}) ";
                         }

                         player += ")";

                         CLP.Append(player + "\n");
                     }
                 }
                 CLP.Append(")\n\n");
                 //Close deffacts (players)

                 //Open deffacts (parameters)
                 CLP.Append("(deffacts parameters\n");
                 foreach (var property in dataModel.GetType().GetProperties())
                 {
                     CLP.AppendFormat("({0} {1})\n", property.Name, dataModel.GetType().GetProperty(property.Name)?.GetValue(dataModel, null));
                 }
                 CLP.Append(")\n\n");
                 //Close deffacts (parameters)
           
                 var UserClipsFile = File.ReadAllText(ClipsFilePath);

                 if (File.Exists("System.clp"))
                 {
                     File.Delete("System.clp");
                 }

                 if (File.Exists("Clips.bat"))
                 {
                     File.Delete("Clips.bat");
                 }

                 //Write the clp file
                 File.WriteAllText("System.clp", CLP.ToString() + UserClipsFile);

                 //Construct the final batch file
                 string Content =
                $"(load* {Path.GetFullPath("System.clp")})\n(reset)\n(run)\n(exit)";

                 //Write the batch file to disk
                 File.WriteAllText("Clips.bat", Content);
             });

            //Return the full path of the batch file in order to form the CLIPSDOS process arguments
            return Path.GetFullPath("Clips.bat");
        }
    }
}
