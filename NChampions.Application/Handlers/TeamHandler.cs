using NChampions.Domain.Commands.Teams;
using NChampions.Domain.Handlers.Interfaces;
using NChampions.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NChampions.Application.Handlers
{
    public class TeamHandler : ITeamHandler
    {
        public Task<ApiResponse> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
