using Microsoft.EntityFrameworkCore;

namespace ShelterAnimalsApi.Models
{
  public class ShelterAnimalsApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public ShelterAnimalsApiContext(DbContextOptions<ShelterAnimalsApiContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Matilda", Species = "Dog", Breed = "Bichon", Age = 7 },
          new Animal { AnimalId = 2, Name = "Rexie", Species = "Dog", Breed = "Boxer", Age = 10 },
          new Animal { AnimalId = 3, Name = "Matilda", Species = "Cat", Breed = "Persian", Age = 2 },
          new Animal { AnimalId = 4, Name = "Pip", Species = "Cat", Breed = "American Short-Hair", Age = 4 },
          new Animal { AnimalId = 5, Name = "Bartholomew", Species = "Cat", Breed = "Calico", Age = 12 }
        );
    }
  }
}