using FantasySportsPro.Domain.Constants;
using FantasySportsPro.Persistance.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasySportsPro.Persistance.DataRequests.TeamPlayers
{
    public class DeletePlayerFromTeam : IDataExecute
    {
        public int PlayerId { get; set; }

        public DeletePlayerFromTeam(int playerId)
        {
            PlayerId = playerId;
        }

        public object? GetParameters() => new { PlayerId };

        public string GetSql() => $@"DELETE FROM {DatabaseConstants.TableNames.TeamPlayers} WHERE PlayerId = @PlayerId";
    }
}
