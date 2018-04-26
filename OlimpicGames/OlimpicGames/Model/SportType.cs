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

        public string sportName { get; set; }

        public ICollection<Player> players { get; set; }

        public OlimpicGame olimpicGame { get; set; }
    }
}
