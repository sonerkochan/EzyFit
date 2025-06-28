using EzyFit.Infrastructure.Data.Models;
using EzyFit.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ezyfit.Infrastructure.Data.Common;
using Microsoft.AspNetCore.Authorization;

namespace EzyFit.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusclesController : ControllerBase
    {
        private readonly IRepository repo;

        public MusclesController(IRepository _repo)
        {
            repo = _repo;
        }

        // GET: api/muscles
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Muscle>>> GetAll()
        {
            var muscles = await repo.AllReadonly<Muscle>().ToListAsync();
            return Ok(muscles);
        }
    }
}
