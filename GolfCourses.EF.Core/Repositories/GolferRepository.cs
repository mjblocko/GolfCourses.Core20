using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GolfCourses.Data.Repositories.Interfaces;
using GolfCourses.Domain.Models;

namespace GolfCourses.EF.Core.Repositories
{
    public class GolferRepository : IGolferRepository
    {
        public GolfCoursesContext Context { get; }

        public GolferRepository(GolfCoursesContext context)
        {
            Context = context;
        }

        public IEnumerable<Golfer> GetAll()
        {
            return Context.GolferProfiles;
        }

        public async Task<Golfer> GetAsync(int id)
        {
            return await Context.GolferProfiles.FindAsync(id);
        }

        public void Add(Golfer golfer)
        {
            throw new NotImplementedException();
        }

        public Golfer Update(Golfer golfCourse)
        {
            throw new NotImplementedException();
        }

        public void Remove(Golfer golfer)
        {
            throw new NotImplementedException();
        }
    }
}