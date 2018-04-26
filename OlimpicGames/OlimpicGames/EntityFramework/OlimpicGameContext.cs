using OlimpicGames.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicGames.EntityFramework
{
    class OlimpicGameContext:DbContext
    {


        public DbSet<Country> countries { get; set; }

        public DbSet<OlimpicGame> olimpicGames { get; set; }

        public DbSet<Player> players { get; set; }

        public DbSet<Result> results { get; set; }

        public DbSet<SportType> sportTypes { get; set; }

        public DbSet<Team> teams { get; set; }
    }
}
