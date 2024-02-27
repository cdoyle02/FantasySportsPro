using FantasySportsPro.Domain.Models;

namespace FantasySportsPro.Application.Request.TeamLookUpRequests.GetByState
{
    public class GetTeamByStateResponse 
    {
        public IEnumerable<TeamLookUp> Teams { get; set; } = Enumerable.Empty<TeamLookUp>();

        public GetTeamByStateResponse(IEnumerable<TeamLookUp> teams)
        {
            Teams = teams;
        }

        public GetTeamByStateResponse()
        {
        }
    }
}
