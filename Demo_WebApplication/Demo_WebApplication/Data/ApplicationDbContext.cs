using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

using Demo_WebApplication.Models;

namespace Demo_WebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Department> Departments { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Demo_WebApplication.Models.Product> Product { get; set; }
    }
}
