namespace Calendar.Models.Dto
{
    public class SessionDto
    {
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
