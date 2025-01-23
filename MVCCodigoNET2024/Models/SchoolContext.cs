using Microsoft.EntityFrameworkCore;

namespace MVCCodigoNET2024.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BCQFL9J\\SQLEXPRESS; " +
                "Database=Codigo2025DB; Integrated Security=True;" +
                "Trust Server Certificate=True;");
        }
    }
}
