using Microsoft.EntityFrameworkCore;
 
namespace Tutor.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }
        public DbSet<User> Users {get; set;}
        public DbSet<Language> Languages {get; set;}
        public DbSet<Tutor> Tutors {get; set;}
    }
}
