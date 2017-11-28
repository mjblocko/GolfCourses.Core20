using GolfCourses.EF.Entities.Interfaces;

namespace GolfCourses.EF.Entities
{
    public class GolfCoursePlayed : IEntityBase
    {
        public int Id { get; set; }

        // Foreign Key
        public int GolferProfileId { get; set; }

        // Navigation Property
        public virtual Golfer Golfer { get; set; }

        // Foreign Key
        public int GolfCourseId { get; set; }

        // Navigation Property
        public virtual GolfCourse GolfCourse { get; set; }
    }
}