using System;
using System.IO;
using System.Linq;
using FluentAssertions;
using GolfCourses.Domain.Models;
using GolfCourses.EF.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace GolfCourses.EF.Core.Exams
{
    public class GolfCourseRepositoryExams
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
        public void GolfCourseRepository_GetAll_ReturnsProperCount()
        {
            using (var context = Context)
            {
                var repo = new GolfCourseRepository(context);
                var courses = repo.GetAll().ToArray();
                courses.Should().NotBeEmpty().And.HaveCount(c => c > 1);
                Console.WriteLine($"Number of GolfCourses is {courses.Count()}");
            }
        }
    }
}