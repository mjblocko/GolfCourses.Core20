using Microsoft.EntityFrameworkCore;
using GolfCourses.EF.Entities;

namespace GolfCourses.EF
{
    public class GolfCoursesContext : DbContext
    {
        public DbSet<Golfer> GolferProfiles { get; set; }
        public DbSet<GolfCourse> GolfCourses { get; set; }
        public DbSet<GolfCoursePlayed> GolfCoursesPlayed { get; set; }

        public GolfCoursesContext(DbContextOptions<GolfCoursesContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            //{
            //    relationship.DeleteBehavior = DeleteBehavior.Restrict;
            //}

            //modelBuilder.Entity<Golfer>().ToTable("Golfer");
            //modelBuilder.Entity<GolfCoursePlayed>().ToTable("GolfCoursePlayed");

            //modelBuilder.Entity<GolfCourse>().ToTable("GolfCourse");
            //modelBuilder.Entity<GolfCourse>().Property(s => s.Name).IsRequired();
            //modelBuilder.Entity<GolfCourse>().Property(s => s.Address).IsRequired();
            //modelBuilder.Entity<GolfCourse>().Property(s => s.City).IsRequired();
            //modelBuilder.Entity<GolfCourse>().Property(s => s.State).IsRequired();

            // modelBuilder.Entity<User>().Property(u => u.Name).HasMaxLength(100).IsRequired();

            //modelBuilder.Entity<Attendee>()
            //    .HasOne(a => a.User)
            //    .WithMany(u => u.SchedulesAttended)
            //    .HasForeignKey(a => a.UserId);

            //modelBuilder.Entity<Attendee>()
            //    .HasOne(a => a.Schedule)
            //    .WithMany(s => s.Attendees)
            //    .HasForeignKey(a => a.ScheduleId);
        }
    }
}