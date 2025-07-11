﻿using EzyFit.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzyFit.Infrastructure.Data.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategories());
        }

        private List<Category> CreateCategories()
        {
            return new List<Category>()
            {
                new Category() { Id = 1, Name = "Cardio" },
                new Category() { Id = 2, Name = "Olympic Weightlifting" },
                new Category() { Id = 3, Name = "Plyometrics" },
                new Category() { Id = 4, Name = "Powerlifting" },
                new Category() { Id = 5, Name = "Strength" },
                new Category() { Id = 6, Name = "Strongman" },
                new Category() { Id = 7, Name = "Stretching" }
            };
        }
    }
}
