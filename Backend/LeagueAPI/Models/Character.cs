using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueAPI.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AtkType { get; set; }
        public string DmgType { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Build> Builds { get; set; }
        public virtual Position Position { get; set; }
        public int PositionId { get; set;}

        public Character(int id, string name, int positionId, string atkType, string dmgType, string image)
        {
            Id = id;
            Name = name;
            PositionId = positionId;
            AtkType = atkType;
            DmgType = dmgType;
            Image = image;
            
        }
        public Character()
        {
        }

    }
}
