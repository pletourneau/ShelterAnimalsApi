using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShelterAnimalsApi.Models;

namespace ShelterAnimalsApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly ShelterAnimalsApiContext _db;

    public AnimalsController(ShelterAnimalsApiContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get()
    {
      return await _db.Animals.ToListAsync();
    }

    // GET: api/Animals/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      Animal animal = await _db.Animals.FindAsync(id);

      if (animal == null)
      {
        return NotFound();
      }

      return animal;
    }
    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    }

  }
}

