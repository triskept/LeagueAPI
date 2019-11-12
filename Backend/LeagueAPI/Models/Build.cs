using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueAPI.Models
{
    public class Build
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Items { get; set; }

        public virtual Character Character { get; set; }
        public int CharacterId { get; set; }

        public Build(int id, string name, string items, int characterId)
        {
            Id = id;
            Name = name;
            Items = items;
            CharacterId = characterId;
        }
        public Build()
        {

        }
    }
}
