using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class JiaoQiuContext : DbContext
    {
        public DbSet<JiaoQiu> Blogs { get; set; }

        public JiaoQiuContext(DbContextOptions<JiaoQiuContext> options) : base(options)
        {
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();  //去除“设置表名为复数”这条约定
        //}
    }
}
