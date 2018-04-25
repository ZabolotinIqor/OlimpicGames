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

        public int idSport { get; set; }

        public int idCountry { get; set; }

        public int idTeam { get; set; }

        public string playerName { get; set; }

        public string playerSurname { get; set; }

        public string playerFathersName { get; set; }

        public DateTime birthDate { get; set; }

        public string playerPhotoUrl{ get; set; }



    }
}
