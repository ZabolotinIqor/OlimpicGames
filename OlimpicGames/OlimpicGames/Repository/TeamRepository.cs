using OlimpicGames.EntityFramework;
using OlimpicGames.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicGames.Repository
{
    class TeamRepository
    {
        private OlimpicGameContext context;

        public IEnumerable<Team> getTeams()
        {
            return context.teams;
        }

        public Team getTeam(int id)
        {
            return context.teams.Find(id);
        }

        public void deleteTeams(int id)
        {
            var team = context.teams.Find(id);
            context.teams.Remove(team);
        }
        public void updateTeam(Team team)
        {
            context.Entry(team).State = EntityState.Modified;
        }
        public void Save()
        {
            context.SaveChanges();
        }

    }
}
