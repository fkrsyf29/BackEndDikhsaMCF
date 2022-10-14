using BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SkillTestController : ControllerBase
    {

        private ApplicationDbContext _dbContext;

        public SkillTestController(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        [HttpGet(template: "getLocation")]
        public IList<Ms_Storage_Location> Get()
        {
            return (this._dbContext.Ms_Storage_Locations.ToList());
        }

        [HttpPost(template: "saveData")]
        public async Task<ActionResult<Tr_Bpkb>> PostTodoItem(Tr_Bpkb item)
        {
            _dbContext.Tr_Bpkbs.Add(item);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
