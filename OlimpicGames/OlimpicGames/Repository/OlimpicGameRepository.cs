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
    class OlimpicGameRepository
    {
        private OlimpicGameContext context;

        public IEnumerable<OlimpicGame> GetOlimpicGames()
        {
            return context.olimpicGames;
        }

        public OlimpicGame getOlimpicGame(int id)
        {
            return context.olimpicGames.Find(id);
        }

        public void deleteOlimpicGame(int id)
        {
            var olimpicGame = context.olimpicGames.Find(id);
            context.olimpicGames.Remove(olimpicGame);
        }

        public void updateOlimpicGame(OlimpicGame olimpic)
        {
            context.Entry(olimpic).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

    }
}
