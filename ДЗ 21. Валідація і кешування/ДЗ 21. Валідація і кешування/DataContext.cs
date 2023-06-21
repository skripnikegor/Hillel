using Microsoft.EntityFrameworkCore;

namespace ДЗ_21._Валідація_і_кешування
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        internal DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        internal DbSet<Student> Students { get; set; }
        internal DbSet<Group> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=WIN-S6883EVAMDH\SQLEXPRESS;Initial Catalog=HW21;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>()
                .HasMany<Student>(g => g.Students)
                .WithOne(s => s.Group)
                .HasForeignKey(s => s.GroupId);
        }
    }
}
