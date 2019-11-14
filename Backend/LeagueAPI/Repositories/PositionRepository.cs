using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueAPI.Models;
using LeagueAPI.Context;
using Microsoft.EntityFrameworkCore;

namespace LeagueAPI.Repositories
{
    public class PositionRepository : Repository<Position>, IRepository<Position>
    {
        private DbContext db;
        public PositionRepository(LeagueContext context) : base(context)
        {
            this.db = context;
        }

        public override Position GetById(int id)
        {
            return db.Set<Position>().Where(i => i.Id == id).Include("Characters").FirstOrDefault();
        }

    }
}
