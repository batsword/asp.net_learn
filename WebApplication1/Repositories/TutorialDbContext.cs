using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

//Pomelo.EntityFrameworkCore.MySql 2.1.0 mysql5.7

namespace WebApplication1.Repositories
{
    public class TutorialDbContext : DbContext
    {
        private IConfiguration Configuration { get; }

        public TutorialDbContext(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Configuration.GetConnectionString("testdb"));
        }

        public DbSet<UserEntity> Users { get; set; }
    }
}
