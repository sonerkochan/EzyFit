﻿// <auto-generated />
using System;
using EzyFit.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EzyFit.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.ActivityLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ActivityLogs");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cardio"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Olympic Weightlifting"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Plyometrics"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Powerlifting"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Strength"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Strongman"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Stretching"
                        });
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Equipments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "No Equipment"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dumbbells"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Barbell"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Kettlebells"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Treadmill"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Elliptical"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Rowing Machine"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Resistance Bands"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Bench Press"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Pull-up Bar"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Medicine Ball"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Foam Roller"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Exercise Mat"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Stationary Bike"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Leg Press Machine"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Cable Machine"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Smith Machine"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Stability Ball"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Jump Rope"
                        });
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int?>("LevelId")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MuscleId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("LevelId");

                    b.HasIndex("MuscleId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.ExerciseLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutLogId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutLogId");

                    b.ToTable("ExerciseLogs");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.Level", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Levels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Beginner"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Intermediate"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Advanced"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Expert"
                        });
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.Muscle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Muscles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Abdominals"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Abductors"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Adductors"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Biceps"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Calves"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Chest"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Forearms"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Glutes"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Hamstrings"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Lats"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Lower Back"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Middle Back"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Neck"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Obliques"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Quadriceps"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Shoulders"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Traps"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Triceps"
                        });
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.SetLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ExerciseLogId")
                        .HasColumnType("int");

                    b.Property<int>("Reps")
                        .HasColumnType("int");

                    b.Property<int>("SetNumber")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseLogId");

                    b.ToTable("SetLogs");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.UserWorkout", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "WorkoutId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("UserWorkouts");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.WorkoutExercise", b =>
                {
                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<string>("Repetitions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tempo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkoutId", "ExerciseId");

                    b.HasIndex("ExerciseId");

                    b.ToTable("WorkoutExercises");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.WorkoutLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.ToTable("WorkoutLogs");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastOnline")
                        .HasColumnType("datetime2");

                    b.Property<string>("PreferredLanguage")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)")
                        .HasDefaultValue("en");

                    b.Property<DateTime?>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.Exercise", b =>
                {
                    b.HasOne("EzyFit.Infrastructure.Data.Models.Category", "Category")
                        .WithMany("Exercises")
                        .HasForeignKey("CategoryId");

                    b.HasOne("EzyFit.Infrastructure.Data.Models.Equipment", "Equipment")
                        .WithMany("Exercises")
                        .HasForeignKey("EquipmentId");

                    b.HasOne("EzyFit.Infrastructure.Data.Models.Level", "Level")
                        .WithMany("Exercises")
                        .HasForeignKey("LevelId");

                    b.HasOne("EzyFit.Infrastructure.Data.Models.Muscle", "Muscle")
                        .WithMany("Exercises")
                        .HasForeignKey("MuscleId");

                    b.Navigation("Category");

                    b.Navigation("Equipment");

                    b.Navigation("Level");

                    b.Navigation("Muscle");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.ExerciseLog", b =>
                {
                    b.HasOne("EzyFit.Infrastructure.Data.Models.WorkoutLog", "WorkoutLog")
                        .WithMany("ExerciseLogs")
                        .HasForeignKey("WorkoutLogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkoutLog");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.SetLog", b =>
                {
                    b.HasOne("EzyFit.Infrastructure.Data.Models.ExerciseLog", "ExerciseLog")
                        .WithMany("SetLogs")
                        .HasForeignKey("ExerciseLogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExerciseLog");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.UserWorkout", b =>
                {
                    b.HasOne("EzyFit.Infrastructure.Data.Models.User", "User")
                        .WithMany("WorkoutIds")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EzyFit.Infrastructure.Data.Models.Workout", "Workout")
                        .WithMany()
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.WorkoutExercise", b =>
                {
                    b.HasOne("EzyFit.Infrastructure.Data.Models.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EzyFit.Infrastructure.Data.Models.Workout", "Workout")
                        .WithMany("ExerciseIds")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.Category", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.Equipment", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.ExerciseLog", b =>
                {
                    b.Navigation("SetLogs");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.Level", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.Muscle", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.Workout", b =>
                {
                    b.Navigation("ExerciseIds");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.WorkoutLog", b =>
                {
                    b.Navigation("ExerciseLogs");
                });

            modelBuilder.Entity("EzyFit.Infrastructure.Data.Models.User", b =>
                {
                    b.Navigation("WorkoutIds");
                });
#pragma warning restore 612, 618
        }
    }
}
