using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueAPI.Models;
using LeagueAPI.Context;
using Microsoft.EntityFrameworkCore;

namespace LeagueAPI.Repositories
{
    public class BuildRepository : Repository<Build>, IRepository<Build>
    {
        private DbContext db;
        public BuildRepository(LeagueContext context) : base(context)
        {
            this.db = context;
        }
    }
}
