using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicGames.Model
{
    class Player
    {
        public int Id { get; set; }

        public string playerName { get; set; }

        public string playerSurname { get; set; }

        public string playerFathersName { get; set; }

        public DateTime birthDate { get; set; }

        public string playerPhotoUrl{ get; set; }

        public SportType sport { get; set; }

        public Country country { get; set; }

        public Team team { get; set; }

        public ICollection<Result> results { get; set; }

    }
}
