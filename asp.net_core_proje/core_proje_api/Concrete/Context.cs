using core_proje_api.Entity;
using Microsoft.EntityFrameworkCore;

namespace core_proje_api.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SHERLOCK\\SQLEXPRESS;Database=CoreProje_api_DB;Integrated Security=True;");
        }

        public DbSet<Category> Category { get; set; }
    }
}
