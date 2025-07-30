﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Persistence.Context
{
    public class MovieContext: IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-8VQTI9O3\\SQLEXPRESS; initial catalog=ApiMovieDb; integrated security=true; TrustServerCertificate=true");
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Cast> Casts { get; set; }
    }
}
