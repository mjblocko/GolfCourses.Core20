using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using GolfCourses.Domain.Models.Interfaces;

namespace GolfCourses.Domain.Models
{
    [Table("Golfers")]
    public class Golfer : IEntityBase
    {
        public int Id { get; set; }

        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public double? ZipCode { get; set; }

        public string UserId { get; set; }

        public ICollection<GolfCoursePlayed> GolfCoursesPlayeds { get; set; }

        public Golfer()
        {
            GolfCoursesPlayeds = new List<GolfCoursePlayed>();
        }
    }
}