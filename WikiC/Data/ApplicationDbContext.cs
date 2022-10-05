using Microsoft.EntityFrameworkCore;
using WikiC.Models;

namespace WikiC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        //Tablas
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostTag> PostToTags { get; set; }

    }
}
