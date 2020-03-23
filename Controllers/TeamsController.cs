using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using baseballapi.Models;

namespace baseballapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TeamsController : ControllerBase
    {
        private readonly baseballdbContext _context;

        public TeamsController(baseballdbContext context)
        {
            _context = context;
        }

        // GET: api/Teams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamShort>>> GetTeamList()
        {
            var query = await _context.Teams.Select(team => new TeamShort
            {
            TeamId = team.TeamId,
            NameDisplayBrief = team.NameDisplayBrief
            })
            .OrderBy(team=>team.NameDisplayBrief)
            .ToListAsync();
            return query;
        }

        // GET: api/Teams/5
        [HttpGet("{team_id}")]
        public async Task<ActionResult<Teams>> GetTeam(string team_id)
        {
            var teams = await _context.Teams.FindAsync(team_id);

            if (teams == null)
            {
                return NotFound();
            }

            return teams;
        }
    }
}
