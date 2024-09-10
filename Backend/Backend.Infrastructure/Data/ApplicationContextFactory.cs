using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Infrastructure.Data
{
    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            //string connectionString = "Server=.\\SqlExpress;Database=FitnessHelper;Trusted_Connection=true;TrustServerCertificate=true;";
            string connectionString = "Server=LAPTOP-I1HN81A5;Database=FitnessHelper;Trusted_Connection=true;TrustServerCertificate=true;";
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .UseLazyLoadingProxies()
                .Options;

            return new ApplicationContext(options);
        }
    }
}
