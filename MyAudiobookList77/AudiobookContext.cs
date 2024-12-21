using Microsoft.EntityFrameworkCore;
using MyAudiobookList.DataAccess.Models;

namespace MyAudiobookList.DataAccess
{
  public class AudiobookContext : DbContext
  {

    public DbSet<AudioBook> AudioBooks { get; set; }

    public AudiobookContext(DbContextOptions<AudiobookContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("Data Source=Database/MyAudiobookDb.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
    }
  }
}
