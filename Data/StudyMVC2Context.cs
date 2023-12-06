using Microsoft.EntityFrameworkCore;
using StudyMVC2.Models;


namespace StudyMVC2.Data
{
    public class StudyMVC2Context : DbContext
    {
        public StudyMVC2Context(DbContextOptions<StudyMVC2Context> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; } = default!;

        public DbSet<Photo> Photos { get; set; } = default!;

        public DbSet<Login> Logins { get; set; } = default!;
    }
}
