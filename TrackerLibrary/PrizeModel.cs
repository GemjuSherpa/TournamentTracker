using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
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

    }
}
