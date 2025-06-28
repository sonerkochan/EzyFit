using EzyFit.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzyFit.Infrastructure.Data.Configuration
{
    internal class MuscleConfiguration : IEntityTypeConfiguration<Muscle>
    {
        public void Configure(EntityTypeBuilder<Muscle> builder)
        {
            builder.HasData(CreateMuscles());
        }

        private List<Muscle> CreateMuscles()
        {
            List<Muscle> muscles = new List<Muscle>()
            {
                new Muscle() { Id = 1, Name = "Abdominals" },
                new Muscle() { Id = 2, Name = "Abductors" },
                new Muscle() { Id = 3, Name = "Adductors" },
                new Muscle() { Id = 4, Name = "Biceps" },
                new Muscle() { Id = 5, Name = "Calves" },
                new Muscle() { Id = 6, Name = "Chest" },
                new Muscle() { Id = 7, Name = "Forearms" },
                new Muscle() { Id = 8, Name = "Glutes" },
                new Muscle() { Id = 9, Name = "Hamstrings" },
                new Muscle() { Id = 10, Name = "Lats" },
                new Muscle() { Id = 11, Name = "Lower Back" },
                new Muscle() { Id = 12, Name = "Middle Back" },
                new Muscle() { Id = 13, Name = "Neck" },
                new Muscle() { Id = 14, Name = "Obliques" },
                new Muscle() { Id = 15, Name = "Quadriceps" },
                new Muscle() { Id = 16, Name = "Shoulders" },
                new Muscle() { Id = 17, Name = "Traps" },
                new Muscle() { Id = 18, Name = "Triceps" }
            };
            return muscles;
        }
    }
}
