using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DBAdaptor.TextHelpers
{
    public static class TextConnectorProcessor
    {
        //Load the text file
        //convert the text to List<PrizeModel>
        //find the max id
        //add new record with new id (max + 1)
        //convert the prizes to a lists of strings
        //save the lists of string to text file

        /// <summary>
        /// extension method for getting full file path given that filename
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns> absulute file path</returns>
        public static string FullFilePath(this string fileName) //PrizeModels.csv
        {
            //C:\data\TournamentTracker\PrizeModels.csv
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
        }

        /// <summary>
        /// Load the file if exists
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        /// <summary>
        /// Extension method for converting the text to List of Prize model
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');
                PrizeModel P = new PrizeModel();

                P.Id = int.Parse(cols[0]);
                P.PlaceNumber = int.Parse(cols[1]);
                P.PlaceName = cols[2];
                P.PrizeAmount = decimal.Parse(cols[3]);
                P.PrizPercentage = double.Parse(cols[4]);

                output.Add(P);
                
            }

            return output;
        }


        /// <summary>
        /// Save the Prize models to csv file.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="fileName"></param>

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach(PrizeModel p in models)
            {
                lines.Add($"{ p.Id }, { p.PlaceNumber },{p.PlaceName},{p.PrizeAmount},{p.PrizPercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
