using Microsoft.AspNetCore.Mvc;
using SportsClub.Models;
using System.Linq;

namespace SportsClub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemberController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Post(Member member)
        {
            using (var context = new SportsClubDBContext())
            {
                Sport sport = context.Sports.First(s=> s.SportId == member.Sport.SportId);
                if (sport != null)
                {
                    member.Sport = sport;
                    context.Members.Add(member);
                    context.SaveChanges();
                    return Ok();
                }
                else
                    return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Put(Member member)
        {
            using (var context = new SportsClubDBContext())
            {
                Sport sport = context.Sports.First(s => s.SportId == member.Sport.SportId);
                if (sport != null)
                {
                    member.Sport = sport;
                    context.Members.Add(member);
                    context.SaveChanges();
                    return Ok();
                }
                else
                    return BadRequest();
            }
        }

        [HttpDelete("/{id}")]
        public IActionResult Delete(int id)
        {
            using (var context = new SportsClubDBContext())
            {
                Member member = context.Members.First(m => m.MemberId == id);
                if (member!= null)
                {
                    context.Members.Add(member);
                    context.SaveChanges();
                    return Ok();
                }
                else
                    return BadRequest();
            }
        }

    }
}
