using Microsoft.EntityFrameworkCore;

namespace WebMonitorBlazor.Data
{
  public class LogContext : DbContext
  {
    public DbSet<Log> logs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql(@"");
    }
  }
}