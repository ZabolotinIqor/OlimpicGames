using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicGames.Model
{
    class OlimpicGame
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime dateOfOlimpicGame { get; set; }

        public bool olimpicType { get; set; }

        public ICollection<SportType> sportTypes { get; set; }

    }
}
