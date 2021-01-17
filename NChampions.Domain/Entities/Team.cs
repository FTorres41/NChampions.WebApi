using System;

namespace NChampions.Domain.Entities
{
    public class Team : Entity
    {
        public string TeamName { get; set; }

        public Team(string teamName)
        {
            Id = Guid.NewGuid();
            TeamName = teamName;
            IsActive = true;
        }

        public Team(Guid id, string teamName, bool isActive)
        {
            Id = id;
            TeamName = teamName;
            IsActive = isActive;
        }
        
        public void UpdateTeam(Team team)
        {
            Id = team.Id;
            TeamName = team.TeamName;
            IsActive = team.IsActive;
        }


    }
}
