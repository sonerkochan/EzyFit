using EzyFit.Infrastructure.Data.Configuration;
using EzyFit.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EzyFit.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        { }


        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutExercise> WorkoutExercises { get; set; }
        public DbSet<UserWorkout> UserWorkouts { get; set; }
        public DbSet<WorkoutLog> WorkoutLogs { get; set; }
        public DbSet<ExerciseLog> ExerciseLogs { get; set; }
        public DbSet<SetLog> SetLogs { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Muscle> Muscles { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .Property(u => u.Email)
                .IsRequired();


            builder.Entity<User>()
                .HasMany(u => u.WorkoutIds);

            builder.Entity<User>()
                .Property(u => u.PreferredLanguage)
                .HasDefaultValue("en");




            builder.Entity<UserWorkout>()
                .HasKey(x => new { x.UserId, x.WorkoutId });

            builder.Entity<WorkoutExercise>().HasKey(we => new { we.WorkoutId, we.ExerciseId });

            // WorkoutLog configuration
            builder.Entity<WorkoutLog>()
                .HasMany(wl => wl.ExerciseLogs)
                .WithOne(el => el.WorkoutLog)
                .HasForeignKey(el => el.WorkoutLogId)
                .OnDelete(DeleteBehavior.Cascade); // To Delete ExerciseLogs when a WorkoutLog is deleted

            // ExerciseLog configuration
            builder.Entity<ExerciseLog>()
                .HasMany(el => el.SetLogs)
                .WithOne(sl => sl.ExerciseLog)
                .HasForeignKey(sl => sl.ExerciseLogId)
                .OnDelete(DeleteBehavior.Cascade); // To Delete SetLogs when an ExerciseLog is deleted



            //builder.ApplyConfiguration(new RoleConfigration());
            builder.ApplyConfiguration(new EquipmentConfiguration());
            builder.ApplyConfiguration(new LevelConfiguration());
            builder.ApplyConfiguration(new MuscleConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
