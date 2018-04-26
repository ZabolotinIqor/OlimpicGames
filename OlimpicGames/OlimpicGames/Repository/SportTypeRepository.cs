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
    class SportTypeRepository
    {
        private OlimpicGameContext context;

        public IEnumerable<SportType> getSportTypes()
        {
            return context.sportTypes;
        }

        public SportType getSportType(int id)
        {
            return context.sportTypes.Find(id);
        }

        public void deleteSportType(int id)
        {
            var sportType = context.sportTypes.Find(id);
            context.sportTypes.Remove(sportType);
        }
        public void updateSportType(SportType sportType)
        {
            context.Entry(sportType).State = EntityState.Modified;
        }
        public void Save()
        {
            context.SaveChanges();
        }

    }
}
