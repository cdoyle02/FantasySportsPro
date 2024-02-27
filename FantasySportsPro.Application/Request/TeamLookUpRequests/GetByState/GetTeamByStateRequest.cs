using FantasySportsPro.Application.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasySportsPro.Application.Request.TeamLookUpRequests.GetByState
{
    public class GetTeamByStateRequest : IRequestWithResponse<GetTeamByStateResponse>
    {
        public string State {  get; set; } = string.Empty;

        public int? SportAssociationId { get; set; }
    }
}
