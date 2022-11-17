using TermProject295N.Models;
using Microsoft.EntityFrameworkCore;

namespace TermProject295N
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Homebrew> HomebrewItems { get; set; }
    }
}
