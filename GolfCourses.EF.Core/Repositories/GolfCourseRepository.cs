using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GolfCourses.Data.Repositories.Interfaces;
using GolfCourses.Domain.Models;

namespace GolfCourses.EF.Core.Repositories
{
    public class GolfCourseRepository : IGolfCourseRepository
    {
        public GolfCoursesContext Context { get; }

        public GolfCourseRepository(GolfCoursesContext context)
        {
            Context = context;
        }

        public IEnumerable<GolfCourse> GetAll()
        {
            return Context.GolfCourses;
        }

        public async Task<GolfCourse> GetAsync(int id)
        {
            return await Context.GolfCourses.FindAsync(id);
        }

        public void Add(GolfCourse golfCourse)
        {
            throw new NotImplementedException();
        }

        public GolfCourse Update(GolfCourse golfCourse)
        {
            throw new NotImplementedException();
        }

        public void Remove(GolfCourse golfCourse)
        {
            throw new NotImplementedException();
        }
    }
}