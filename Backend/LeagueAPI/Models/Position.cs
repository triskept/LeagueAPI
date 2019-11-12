using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueAPI.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Character> Characters { get; set; }

        public Position(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Position()
        {

        }
    }
}
