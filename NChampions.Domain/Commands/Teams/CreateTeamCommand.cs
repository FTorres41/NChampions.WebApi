using NChampions.Domain.Commands.Interfaces;

namespace NChampions.Domain.Commands.Teams
{
    public class CreateTeamCommand : ICommand
    {
        public string TeamName { get; set; }
    }
}
