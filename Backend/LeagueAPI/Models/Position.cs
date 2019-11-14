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
        public string Image { get; set; }

        public virtual ICollection<Character> Characters { get; set; }

        public Position(int id, string name, string image)
        {
            Id = id;
            Name = name;
            Image = image;
        }
        public Position()
        {

        }
    }
}
