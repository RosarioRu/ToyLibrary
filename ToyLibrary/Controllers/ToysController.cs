using System.Collections.Generic;
using System.Linq; // needed for .Any() method
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToyLibrary.Models;

namespace ToyLibrary.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ToysController: ControllerBase
  {

    private readonly ToyLibraryContext _db;

    public ToysController(ToyLibraryContext db)
    {
      _db = db;
    }

    //GET api/toys
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Toy>>> Get()
    {
      return await _db.Toys.ToListAsync();
    }

    //POST api/toys
    [HttpPost]
    public async Task<ActionResult<Toy>> Post (Toy toy)
    {
      _db.Toys.Add(toy);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetToy), new {id = toy.ToyId}, toy);
    }

    //GET: api/Toys/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Toy>> GetToy(int id)
    {
      var toy = await _db.Toys.FindAsync(id);
      if (toy == null)
      {
        return NotFound();
      }
      return toy;
    }

    // PUT: api/toys/1
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Toy toy)
    {
      if (id != toy.ToyId)
      {
        return BadRequest();
      }

      _db.Entry(toy).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ToyExists(id))
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

    private bool ToyExists(int id)
    {
      return _db.Toys.Any(e => e.ToyId == id);
    }

    // DELETE: api/Toys/1
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteToy(int id)
    {
      var toy = await _db.Toys.FindAsync(id);
      if (toy == null)
      {
        return NotFound();
      }

      _db.Toys.Remove(toy);
      await _db.SaveChangesAsync();

      return NoContent();
    }

  }
}

