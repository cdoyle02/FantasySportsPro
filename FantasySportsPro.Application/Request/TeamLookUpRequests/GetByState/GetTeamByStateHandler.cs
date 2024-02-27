using FantasySportsPro.Application.BaseObjects.BaseHandlers;
using FantasySportsPro.Persistance.Abstraction;
using FantasySportsPro.Persistance.DataRequests.TeamLookUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasySportsPro.Application.Request.TeamLookUpRequests.GetByState
{
    internal class GetTeamByStateHandler : DataRequestResponseHandler<GetTeamByStateRequest, GetTeamByStateResponse>
    {
        public GetTeamByStateHandler(IDataAccess dataAccess) : base(dataAccess)
        {
        }

        public async override Task<GetTeamByStateResponse> GetResponseAsync(GetTeamByStateRequest request)
        {
            var teams = await _dataAccess.FetchListAsync(new FetchTeamByState(request.State, request?.SportAssociationId));

            return new GetTeamByStateResponse(teams);
        }
    }
}
