using System;
using System.Collections.Generic;
using System.Text;
using BasicCleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BasicCleanArch.Persistence.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
