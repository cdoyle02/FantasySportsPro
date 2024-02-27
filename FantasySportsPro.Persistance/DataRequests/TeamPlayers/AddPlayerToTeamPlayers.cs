using FantasySportsPro.Domain.Constants;
using FantasySportsPro.Persistance.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasySportsPro.Persistance.DataRequests.TeamPlayers
{
    public class AddPlayerToTeamPlayers : IDataExecute
    {
        public int TeamPlayerLookUpId { get; set; }
        public int PlayerId { get; set; }
        public AddPlayerToTeamPlayers(int teamPlayerLookUpId, int playerId)
        {
            TeamPlayerLookUpId = teamPlayerLookUpId;
            PlayerId = playerId;
        }

        public object? GetParameters() => new { TeamPlayerLookUpId, PlayerId };

        public string GetSql() => $@"INSERT INTO {DatabaseConstants.TableNames.TeamPlayers} (TeamLookUpId, PlayerId)
                                     VALUES (@TeamPlayerLookUp, @PlayerId)";
    }
}
