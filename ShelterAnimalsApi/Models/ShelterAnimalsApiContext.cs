using Microsoft.EntityFrameworkCore;

namespace ShelterAnimalsApi.Models
{
  public class ShelterAnimalsApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public ShelterAnimalsApiContext(DbContextOptions<ShelterAnimalsApiContext> options) : base(options)
    {
    }
  }
}