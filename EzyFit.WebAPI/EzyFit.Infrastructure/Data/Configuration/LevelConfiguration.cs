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
    internal class LevelConfiguration : IEntityTypeConfiguration<Level>
    {
        public void Configure(EntityTypeBuilder<Level> builder)
        {
            builder.HasData(CreateLevels());
        }

        private List<Level> CreateLevels()
        {
            return new List<Level>
            {
                new Level { Id = 1, Name = "Beginner" },
                new Level { Id = 2, Name = "Intermediate" },
                new Level { Id = 3, Name = "Advanced" },
                new Level { Id = 4, Name = "Expert" }
            };
        }
    }
}
