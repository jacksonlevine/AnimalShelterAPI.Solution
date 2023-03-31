using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Rex", Species = "Dog", Age = 7 },
          new Animal { AnimalId = 2, Name = "Dogtor", Species = "Cat", Age = 10 },
          new Animal { AnimalId = 3, Name = "Johnny", Species = "Shark", Age = 2 },
          new Animal { AnimalId = 4, Name = "Pip", Species = "Owl", Age = 4 },
          new Animal { AnimalId = 5, Name = "Maxwell", Species = "Rhino", Age = 22 },
          new Animal { AnimalId = 5, Name = "Tony", Species = "Rhino", Age = 24 }
        );
    }
  }
}