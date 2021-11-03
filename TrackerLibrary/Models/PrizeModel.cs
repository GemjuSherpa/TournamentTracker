using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the place number of team in the tournament
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name of the place 
        /// example; first, second, third
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the prize amount won
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents what percentage of prize 
        /// </summary>
        public double PrizPercentage { get; set; }

        /// <summary>
        /// constructor method
        /// </summary>
        public PrizeModel()
        {

        }

        /// <summary>
        /// Constructor method for string conversion of properties values to set
        /// </summary>
        /// <param name="placeName"></param>
        /// <param name="placeNumber"></param>
        /// <param name="prizeAmount"></param>
        /// <param name="prizePercentage"></param>
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage )
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizPercentage = prizePercentageValue;

        }
    }
}
