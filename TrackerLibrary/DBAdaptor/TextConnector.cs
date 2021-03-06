using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DBAdaptor.TextHelpers;
namespace TrackerLibrary.DBAdoptor
{
    public class TextConnector: IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";

        /// <summary>
        /// Text Connection
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {

            //Load the text file
            //convert the text to List<PrizeModel>
            List<PrizeModel> prizes =  PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //find the max id
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            //add new record with new id (max + 1)
            model.Id = currentId;
            prizes.Add(model);


            //convert the prizes to a lists of strings
            //save the lists of string to text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
