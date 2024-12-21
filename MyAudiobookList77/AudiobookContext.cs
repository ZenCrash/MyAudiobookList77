using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyAudiobookList.DataAccess.Models;

namespace MyAudiobookList.DataAccess
{
  public class AudiobookContext : DbContext
  {

    public DbSet<AudioBook> AudioBooks { get; set; }

    private readonly string _connectionString;

    public AudiobookContext(IConfiguration configuration, DbContextOptions<AudiobookContext> options) : base(options)
    {
      _connectionString = configuration.GetConnectionString("MyAudiobookDB") ?? string.Empty;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      string baseDirectory = AppContext.BaseDirectory;
      string projectDirectory = Directory.GetParent(baseDirectory)?.Parent?.Parent?.FullName;
      string path = Path.Combine(projectDirectory, @"Database/MyAudiobookDb.db");
      optionsBuilder.UseSqlite(path);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
    }
  }
}
