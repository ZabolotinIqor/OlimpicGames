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
    class ResultRepository
    {
        private OlimpicGameContext context;

        public IEnumerable<Result> getResults()
        {
            return context.results;
        }

        public Result getResult(int id)
        {
            return context.results.Find(id);
        }

        public void deleteResult(int id)
        {
            var result = context.results.Find(id);
            context.results.Remove(result);
        }
        public void updateResult(Result result)
        {
            context.Entry(result).State = EntityState.Modified;
        }
        public void Save()
        {
            context.SaveChanges();
        }

    }
}
