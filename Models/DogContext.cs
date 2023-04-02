using Microsoft.EntityFrameworkCore;
namespace Animals.Models
{
    public class DogContext : DbContext
    {
       
        
            public DbSet<Dog> Phones { get; set; }
          

            public DogContext(DbContextOptions<DogContext> options)
                : base(options)
            {
            }
        

    }
}
