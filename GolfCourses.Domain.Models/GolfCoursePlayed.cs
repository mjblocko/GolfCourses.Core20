using GolfCourses.Domain.Models.Interfaces;

namespace GolfCourses.Domain.Models
{
    public class GolfCoursePlayed : IEntityBase
    {
        public int Id { get; set; }

        // Foreign Key
        public int GolferId { get; set; }

        // Navigation Property
        public virtual Golfer Golfer { get; set; }

        // Foreign Key
        public int GolfCourseId { get; set; }

        // Navigation Property
        public virtual GolfCourse GolfCourse { get; set; }
    }
}