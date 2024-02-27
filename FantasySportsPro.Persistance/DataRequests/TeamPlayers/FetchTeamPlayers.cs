using FantasySportsPro.Domain.Models;
using FantasySportsPro.Persistance.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasySportsPro.Persistance.DataRequests.TeamPlayers
{
    public class FetchTeamPlayers : IDataFetch<Domain.Models.TeamPlayers>
    {
        public int TeamLookUpId { get; set; }

        public FetchTeamPlayers(int teamLookUpId)
        {
            TeamLookUpId = teamLookUpId;
        }

        public object? GetParameters() => new { TeamLookUpId };

        public string GetSql() => @$"SELECT * FROM TeamPlayers (WITH)NOLOCK WHERE TeamLookUpId = @TeamLookUpId";
    }
}
