using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GolfCourses.EF.Entities.Interfaces;

namespace GolfCourses.EF.Entities
{
    [Table("GolfCourses")]
    public class GolfCourse : IEntityBase
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }
        public GolfCourseType Accessibility { get; set; }
        public string Architect { get; set; }
    }
}