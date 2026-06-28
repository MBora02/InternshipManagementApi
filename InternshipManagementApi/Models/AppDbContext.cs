using Microsoft.EntityFrameworkCore;

namespace InternshipManagementApi.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Internship> Internships { get; set; }
        public DbSet<Report> Reports { get; set; }

    }
}
