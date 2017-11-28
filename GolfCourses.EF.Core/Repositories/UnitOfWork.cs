using System.Threading.Tasks;
using GolfCourses.Data.Repositories.Interfaces;

namespace GolfCourses.EF.Core.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public GolfCoursesContext Context { get; }

        public UnitOfWork(GolfCoursesContext context)
        {
            Context = context;
        }

        public async Task CompleteAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}