using Calendar.Models;
using Calendar.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Calendar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly ApplicationDbContext _Context;

        public SessionController(ApplicationDbContext context)
        {
            _Context = context;
        }
        // Create a Session
        [HttpPost("CreateSession")]
        public async Task<IActionResult> Post([FromBody] SessionDto value)
        {
            Session session = new Session();
            session.SessionTitle = value.SessionTitle;
            session.SessionDescription = value.SessionDescription;
            session.StartDate = value.StartDate;
            session.EndDate = value.EndDate;
            session.UserId = value.UserId;
            session.SkillId = value.SkillId;
            session.CourseId = value.CourseId;
            session.Duration = value.Duration;

            _Context.sessions.Add(session);
            _Context.SaveChanges();
            return Ok();

        }


    }
}
