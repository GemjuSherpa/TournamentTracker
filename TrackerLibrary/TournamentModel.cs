using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {

        /// <summary>
        /// Represents the name of tournament
        /// 
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the entry fee to enter tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the lists of entered teams
        /// </summary>
        public List<TeamModel> EnteredTeam { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents the prize for the tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the lists of round in the tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
