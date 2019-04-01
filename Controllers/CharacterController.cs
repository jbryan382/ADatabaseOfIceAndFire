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
    public ActionResult<IList<Character>> GetAllCharacters()
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
    [HttpPut("{id}")]
    public async Task<IActionResult> PutHouse(int id, House house)
    {
      if (id != house.Id)
      {
        return BadRequest();
      }

      db.Entry(house).State = EntityState.Modified;

      try
      {
        await db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!CharacterExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool CharacterExists(int id)
    {
      throw new NotImplementedException();
    }

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
