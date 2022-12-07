using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calendar.Models
{
    public class Session
    {
        [Key]
        public Guid SessionId { get; set; }
        public string SessionTitle { get; set; }
        public string SessionDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UserId { get; set; }
        public int SkillId { get; set; }
        public int CourseId { get; set; }
        public int Duration { get; set; }

    }
}
