using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using adatabaseoficeandfire;
using ADatabaseOfIceAndFire.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ADatabaseOfIceAndFire.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CharacterController : ControllerBase
  {
    private DatabaseContext db;

    public CharacterController()
    {
      this.db = new DatabaseContext();
    }

    [HttpGet]
    public ActionResult<IList<Character>> GetAllSpecies()
    {
      var characters = db.Characters.OrderBy(o => o.Name).ToList();

      return characters;
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Character> Get(int id)
    {
      var house = db.Characters.FirstOrDefault(f => f.Id == id);
      return house;
    }

    // POST api/values
    [HttpPost]
    public async Task<ActionResult<Character>> CreateCharacter(Character newCharacter)
    {
      db.Characters.Add(newCharacter);
      // update the current capacity 
      var house = await db.Characters.FirstOrDefaultAsync(f => f.Id == newCharacter.HouseId);
      await db.SaveChangesAsync();
      return newCharacter;
    }
    // // PUT api/values/5
    // [HttpPut("{id}")]
    // public void Put(int id, [FromBody] string value)
    // {
    // }

    [HttpDelete("{id}")]
    public ActionResult DeleteSingleCharacter(int id)
    {
      var character = db.Characters.FirstOrDefault(f => f.Id == id);
      db.Characters.Remove(character);
      db.SaveChanges();
      return Ok();
    }
  }
}
