using FantasySportsPro.Domain.Constants;
using FantasySportsPro.Persistance.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasySportsPro.Persistance.DataRequests.TeamLookUp
{
    public class FetchTeamBySportAssociationId : IDataFetch<Domain.Models.TeamLookUp>
    {
        #region Properties

        public int SportAssocationId { get; set; }

        #endregion

        #region Constructors

        public FetchTeamBySportAssociationId(int sportAssocationId) =>
            SportAssocationId = sportAssocationId;

        #endregion

        #region Public Methods

        public object? GetParameters() => new { SportAssocationId };

        public string GetSql() => $@"SELECT * FROM {DatabaseConstants.TableNames.TeamLookUp} WITH(NOLOCK) WHERE SportAssocationId = @SportAssocationId";

        #endregion
    }
}
