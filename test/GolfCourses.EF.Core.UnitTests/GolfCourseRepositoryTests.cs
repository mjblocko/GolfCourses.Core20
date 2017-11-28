using System.Linq;
using GolfCourses.Domain.Models;
using GolfCourses.EF.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace GolfCourses.EF.Core.UnitTests
{
    public class GolfCourseRepositoryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GolfCoursesRepo_AddItems_GetAllReturnsProperCount()
        {
            var options = new DbContextOptionsBuilder<GolfCoursesContext>()
                .UseInMemoryDatabase(databaseName: "Add_writes_to_database")
                .Options;

             // Insert seed data into the database using one instance of the context
            using (var context = new GolfCoursesContext(options))
            {
                context.GolfCourses.Add(
                    new GolfCourse()
                    {
                        Name = "Tanners Brook Golf Club",
                        Address = "5810 190th St. N",
                        City = "Forest Lake",
                        State = "MN",
                        Zip = "55025",
                        Phone = "(651) 464-2300",
                    });
                context.GolfCourses.Add(
                    new GolfCourse()
                    {
                        Name = "TPC of the Twin Cities",
                        Address = "1989 110th Ct.NE",
                        City = "Blaine",
                        State = "MN",
                        Zip = "55449",
                        Phone = "(763)785-0800",
                    });

                context.GolfCourses.Add(
                    new GolfCourse
                    {
                        Name = "Bellwood Oaks Golf Course",
                        Address = "13239 210th St. E",
                        City = "Hastings",
                        State = "MN",
                        Zip = "55033",
                        Phone = "(651)437-4141",
                        Architect = "",
                    });
                context.SaveChanges();
            }
             // Use a clean instance of the context to run the test
            using (var context = new GolfCoursesContext(options))
            {
                var repo = new GolfCourseRepository(context);
                var result = repo.GetAll();
                Assert.AreEqual(2, result.Count());
            }
        }
    }
}