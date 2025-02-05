using Microsoft.EntityFrameworkCore.Design;

namespace Ordering.Infrastructure.Data;

public class DesignTimeDbContextFactory :  IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        
        optionsBuilder.UseSqlServer("Server=localhost;Database=OrderDb;User Id=sa;Password=SwN12345678;Encrypt=false;TrustServerCertificate=True");

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}