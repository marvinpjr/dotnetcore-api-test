using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatsKeeper.Api.Model
{
    public class Player
    {
        public int PlayerId { get; set; }
        public int JerseyNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // public List<Team> Teams { get; set; }
    }
}
