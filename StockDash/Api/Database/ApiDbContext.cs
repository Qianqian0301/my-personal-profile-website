using Microsoft.EntityFrameworkCore;

public class ApiDbContext : DbContext
{
    public ApiDbContext (DbContextOptions<ApiDbContext> context) : base(context)
    {
 
    }
    public DbSet<SharesiesInstrument> Students { get; set; }
}