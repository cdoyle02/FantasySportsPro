using FantasySportsPro.Domain.Constants;
using FantasySportsPro.Persistance.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasySportsPro.Persistance.DataRequests.TeamLookUp
{
    public class FetchTeamByState : IDataFetch<Domain.Models.TeamLookUp>
    {
        #region Properties

        public string State { get; set; }

        public int? SportAssocationId { get; set; }

        #endregion

        #region Constructors

        public FetchTeamByState(string state)
        {
            State = state;
        }

        public FetchTeamByState(string state, int? sportAssocationId)
        { 
            State = state;
            SportAssocationId = sportAssocationId;
        }

        #endregion

        #region Public Methods

        public object? GetParameters() => 
            SportAssocationId != null 
                ? new { State, SportAssocationId } 
                : new { State };

        public string GetSql() =>
            SportAssocationId != null
                ? $@"SELECT * FROM {DatabaseConstants.TableNames.TeamLookUp} WITH(NOLOCK) WHERE State LIKE '%@State%' AND SportAssociationId = @SportAssociationId"
                : $@"SELECT * FROM {DatabaseConstants.TableNames.TeamLookUp} WITH(NOLOCK) WHERE State = '%@State%'";

        #endregion
    }
}
