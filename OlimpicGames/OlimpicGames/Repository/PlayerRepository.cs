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
    class PlayerRepository
    {
        private OlimpicGameContext context;

        public IEnumerable<Player> getPlayers()
        {
            return context.players;
        }

        public Player getPlayer(int id)
        {
            return context.players.Find(id);
        }

        public void deletePlayer(int id)
        {
            var player = context.players.Find(id);
            context.players.Remove(player);
        }
        public void updatePlayer(Player player)
        {
            context.Entry(player).State = EntityState.Modified;
        }
        public void Save()
        {
            context.SaveChanges();
        }

    }
}
