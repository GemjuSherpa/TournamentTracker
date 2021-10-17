using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Lists of matchup entries
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }

        /// <summary>
        /// Winner of the tournament
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// represents the matchup round
        /// </summary>
        public int MatchupRound { get; set; }

    }
}
