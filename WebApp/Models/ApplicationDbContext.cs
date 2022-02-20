﻿using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public  DbSet<Category> Categories { get; set; }
    }
}
