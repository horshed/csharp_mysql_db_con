using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banka.models
{
    internal class ApplicationConnectionDB :DbContext
    {
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySql("server=localhost;port=3306;user=root;password=;database=tclogin")
                .UseLoggerFactory(LoggerFactory.Create(b => b
                .AddFilter(level => level <= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();

        }

        public DbSet<kisi> kisi { get; set; }
    }
}
