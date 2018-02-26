using System.Collections.Generic;

namespace StatsKeeper.Api.Model
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Player> Players { get; set; }
    }
}
