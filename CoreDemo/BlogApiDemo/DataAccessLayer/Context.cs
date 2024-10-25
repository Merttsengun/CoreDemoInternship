using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-9JHFH97\\SQLEXPRESS;database=CoreBlogApiDb; integrated security=true;");
        }
        public DbSet<Employee> Empoloyees { get; set; }
    }
}
