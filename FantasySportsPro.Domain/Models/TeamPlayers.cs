using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasySportsPro.Domain.Models
{
    public class TeamPlayers
    {
        public int Id { get; set; }
        public int TeamLookUpId { get; set; }
        public int PlayerId { get; set; }

        public TeamPlayers(int id, int teamLookUpId, int playerId)
        {
            Id = id;
            TeamLookUpId = teamLookUpId;
            PlayerId = playerId;
        }
    }
}
