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
    [Route("api/characters")]
    [ApiController]
    public class CharacterController : ControllerBase
    {

        private IRepository<Character> characterRepo;

        public CharacterController(IRepository<Character> characterRepo)
        {
            this.characterRepo = characterRepo;
        }

        // GET api/characters
        [HttpGet]
        public IEnumerable<Character> Get()
        {
            return characterRepo.GetAll();
        }

        // GET api/characters/5
        [HttpGet("{id}")]
        public Character Get(int id)
        {
            return characterRepo.GetById(id);
        }

        // POST api/characters
        [HttpPost]
        public IEnumerable<Character> Post([FromBody] Character character)
        {
            characterRepo.Create(character);
            return characterRepo.GetAll();
        }

        // PUT api/characters/5
        [HttpPut("{id}")]
        public IEnumerable<Character> Put([FromBody] Character character)
        {
            characterRepo.Update(character);
            return characterRepo.GetAll();
        }

        // DELETE api/characters/5
        [HttpDelete("{id}")]
        public IEnumerable<Character> Delete(int id)
        {
            var character = characterRepo.GetById(id);
            characterRepo.Delete(character);
            return characterRepo.GetAll();
        }
    }
}