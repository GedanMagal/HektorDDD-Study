using System;
using HektorAPI.Core.Entities;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace HektorAPI.Infra.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {}

        public DbSet<Movie> Movies {get; set;}
    }
}