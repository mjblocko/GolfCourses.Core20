using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace GolfCourses.EF.Core
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<GolfCoursesContext>
    {
        public GolfCoursesContext CreateDbContext(string[] args)
        {
            //var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json").Build();

            var builder = new DbContextOptionsBuilder<GolfCoursesContext>();

            //var connectionString = configuration.GetConnectionString("Default");

            //builder.UseSqlServer(connectionString);

            return new GolfCoursesContext(builder.Options);
        }
    }
}