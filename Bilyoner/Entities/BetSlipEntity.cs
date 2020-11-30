using System.Collections.Generic;

namespace Bilyoner.Entities
{
    public class BetSlipEntity
    {
        public List<string> BettedMatchesList { get; set; }
        public int BettedMatchCount { get; set; }
        public List<string> BettedMatchesListInMyBetSlips { get; set; }
    }
}
