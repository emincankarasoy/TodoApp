using Microsoft.EntityFrameworkCore;
using TodoApp.Domain.Entities;

namespace TodoApp.Persistance.Contexts
{
    public class AppDBContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Note> Notes { get; set; }

        public DbSet<Reminder> Reminders { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Domain.Entities.Task> Tasks { get; set; }
        
        public DbSet<Location> Locations { get; set; }

        public DbSet<User> Users { get; set; }

        public AppDBContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(e =>
            {
                e.ToTable(nameof(Categories)).HasKey(k => k.Id);
                e.HasOne(f => f.OwnerUser).WithMany();
            });

            modelBuilder.Entity<Note>(e =>
            {
                e.ToTable(nameof(Notes)).HasKey(k => k.Id);
                e.HasOne(f => f.Task).WithMany(w => w.Notes);
                e.HasOne(f => f.OwnerUser).WithMany();
            });

            modelBuilder.Entity<Reminder>(e =>
            {
                e.ToTable(nameof(Reminders)).HasKey(k => k.Id);
                e.HasOne(f => f.Task).WithOne(w => w.Reminder).HasForeignKey<Reminder>(k => k.Id);
                e.HasOne(f => f.OwnerUser).WithMany();
            });

            modelBuilder.Entity<Tag>(e =>
            {
                e.ToTable(nameof(Tags)).HasKey(k => k.Id);
                e.HasMany(f => f.Tasks).WithMany(w => w.Tags).UsingEntity<TaskTags>();
                e.HasOne(f => f.OwnerUser).WithMany();
            });

            modelBuilder.Entity<Location>(e =>
            {
                e.ToTable(nameof(Locations)).HasKey(k => k.Id);
                e.HasOne(f => f.Task).WithOne(w => w.Location).HasForeignKey<Location>(k => k.Id);
                e.HasOne(f => f.OwnerUser).WithMany();
            });

            modelBuilder.Entity<User>(e =>
            {
                e.ToTable(nameof(Users)).HasKey(k => k.Id);
            });



            base.OnModelCreating(modelBuilder);
        }
    }
}
