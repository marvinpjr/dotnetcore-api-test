using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatsKeeper.Api.Model
{
    public class Player
    {
        public int Id { get; set; }
        public int JerseyNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
