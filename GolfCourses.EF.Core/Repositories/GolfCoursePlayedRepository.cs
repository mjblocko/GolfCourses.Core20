using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GolfCourses.Data.Repositories.Interfaces;
using GolfCourses.Domain.Models;

namespace GolfCourses.EF.Core.Repositories
{
    public class GolfCoursePlayedRepository : IGolfCoursePlayedRepository
    {
        public GolfCoursesContext Context { get; }

        public GolfCoursePlayedRepository(GolfCoursesContext context)
        {
            Context = context;
        }

        public IEnumerable<GolfCoursePlayed> GetAll()
        {
            return Context.GolfCoursesPlayed;
        }

        public async Task<GolfCoursePlayed> GetAsync(int id)
        {
            return await Context.GolfCoursesPlayed.FindAsync(id);
        }

        public void Add(GolfCoursePlayed golfCoursePlayed)
        {
            throw new NotImplementedException();
        }

        public GolfCoursePlayed Update(GolfCoursePlayed golfCourse)
        {
            throw new NotImplementedException();
        }

        public void Remove(GolfCoursePlayed golfCoursePlayed)
        {
            throw new NotImplementedException();
        }
    }
}