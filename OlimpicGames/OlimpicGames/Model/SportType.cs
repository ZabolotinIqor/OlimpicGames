using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicGames.Model
{
    class SportType
    {
        public int Id { get; set; }

        public int idOlimpicGame { get; set; }

        public string sportName { get; set; }
    }
}
