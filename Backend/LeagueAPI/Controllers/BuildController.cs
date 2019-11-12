using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueAPI.Models;
using LeagueAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeagueAPI.Controllers
{
    [Route("api/builds")]
    [ApiController]
    public class BuildController : ControllerBase
    {

        private IRepository<Build> buildRepo;

        public BuildController(IRepository<Build> buildRepo)
        {
            this.buildRepo = buildRepo;
        }

        // GET api/Builds
        [HttpGet]
        public IEnumerable<Build> Get()
        {
            return buildRepo.GetAll();
        }

        // GET api/Builds/5
        [HttpGet("{id}")]
        public Build Get(int id)
        {
            return buildRepo.GetById(id);
        }

        // POST api/Builds
        [HttpPost]
        public IEnumerable<Build> Post([FromBody] Build Build)
        {
            buildRepo.Create(Build);
            return buildRepo.GetAll();
        }

        // PUT api/Builds/5
        [HttpPut("{id}")]
        public IEnumerable<Build> Put([FromBody] Build Build)
        {
            buildRepo.Update(Build);
            return buildRepo.GetAll();
        }

        // DELETE api/Builds/5
        [HttpDelete("{id}")]
        public IEnumerable<Build> Delete(int id)
        {
            var Build = buildRepo.GetById(id);
            buildRepo.Delete(Build);
            return buildRepo.GetAll();
        }
    }
}