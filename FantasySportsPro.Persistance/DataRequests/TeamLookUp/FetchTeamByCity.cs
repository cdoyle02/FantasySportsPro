using FantasySportsPro.Domain.Constants;
using FantasySportsPro.Persistance.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasySportsPro.Persistance.DataRequests.TeamLookUp
{
    public class FetchTeamByCity : IDataFetch<Domain.Models.TeamLookUp>
    {
        #region Properties

        public string City { get; set; }
        public int? SportAssociationId { get; set; }

        #endregion

        #region Constructors

        public FetchTeamByCity(string city)
        {
            City = city;
        }

        public FetchTeamByCity(string city, int? sportAssociationId)
        {
            City = city;
            SportAssociationId = sportAssociationId;
        }

        #endregion

        #region Public Methods

        public object? GetParameters() => 
            SportAssociationId != null 
                ? new { City, SportAssociationId } 
                : new { City };

        public string GetSql() =>
            SportAssociationId != null
                ? $@"SELECT * FROM {DatabaseConstants.TableNames.TeamLookUp} WITH(NOLOCK) WHERE City LIKE '%@City%' AND SportAssociationId = @SportAssociationId"
                : $@"SELECT * FROM {DatabaseConstants.TableNames.TeamLookUp} WITH(NOLOCK) WHERE City = '%@City%'";

        #endregion
    }
}
