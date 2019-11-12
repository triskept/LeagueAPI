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
    [Route("api/positions")]
    [ApiController]
    public class PositionController : ControllerBase
    {

        private IRepository<Position> positionRepo;

        public PositionController(IRepository<Position> positionRepo)
        {
            this.positionRepo = positionRepo;
        }

        // GET api/Positions
        [HttpGet]
        public IEnumerable<Position> Get()
        {
            return positionRepo.GetAll();
        }

        // GET api/Positions/5
        [HttpGet("{id}")]
        public Position Get(int id)
        {
            return positionRepo.GetById(id);
        }

        // POST api/Positions
        [HttpPost]
        public IEnumerable<Position> Post([FromBody] Position Position)
        {
            positionRepo.Create(Position);
            return positionRepo.GetAll();
        }

        // PUT api/Positions/5
        [HttpPut("{id}")]
        public IEnumerable<Position> Put([FromBody] Position Position)
        {
            positionRepo.Update(Position);
            return positionRepo.GetAll();
        }

        // DELETE api/Positions/5
        [HttpDelete("{id}")]
        public IEnumerable<Position> Delete(int id)
        {
            var Position = positionRepo.GetById(id);
            positionRepo.Delete(Position);
            return positionRepo.GetAll();
        }
    }
}