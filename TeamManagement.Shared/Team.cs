using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManagement.Shared
{
    public class Team
    {
        public int TeamId { get; set; }
        public int TeamName { get; set; }
        public List<Player> Players { get; set; }
    }
}
