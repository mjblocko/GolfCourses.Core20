using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace GolfCourses.EF.Core.Exams
{
    public class GolfCourseContextExams
    {
        public static IConfiguration Configuration { get; set; }

        [SetUp]
        public void Setup()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<GolfCoursesContext>();
            var connectionString = Configuration.GetConnectionString("Default");
            optionsBuilder.UseSqlServer(connectionString);

            Context = new GolfCoursesContext(optionsBuilder.Options);
            Context.Database.EnsureCreated();
        }

        public GolfCoursesContext Context { get; set; }

        [Test]
        public void Test1()
        {
            using (var context = Context)
            {
                context.SaveChanges();
            }
        }
    }
}