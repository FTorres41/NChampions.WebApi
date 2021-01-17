using NChampions.Domain.Commands.Teams;
using NChampions.Domain.Responses;

namespace NChampions.Domain.Handlers.Interfaces
{
    public interface ITeamHandler : MediatR.IRequestHandler<CreateTeamCommand, ApiResponse>
    {
    }
}
