using System.Collections.Generic;
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

  }
}

