using dot_net_web_api.Models;
using Microsoft.EntityFrameworkCore;

namespace dot_net_web_api.Data
{
    public class StudentEntities : DbContext
    {
        public StudentEntities(DbContextOptions<StudentEntities> options) : base(options)
        { 
        
        }

        public DbSet<Student> Students { get; set; }
    }
}
