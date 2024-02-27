using FantasySportsPro.Domain.Constants;
using FantasySportsPro.Persistance.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasySportsPro.Persistance.DataRequests.TeamLookUp
{
    public class FetchTeamById : IDataFetch<Domain.Models.TeamLookUp>
    {
        public int Id { get; set; }

        public FetchTeamById(int id)
        {
            Id = id;
        }

        public object? GetParameters() => new { Id };

        public string GetSql() => $@"SELECT * FROM {DatabaseConstants.TableNames.TeamLookUp} WITH(NOLOCK) WHERE Id = @Id";
    }
}
