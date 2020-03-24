using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using baseballapi.Models;
#nullable enable

namespace baseballapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class HittingController : ControllerBase
    {
        private readonly baseballdbContext _context;

        public HittingController(baseballdbContext context)
        {
            _context = context;
        }

        // GET: api/hitting?season=2019
        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<HittingSeason>>> GetSeasonHitting([FromQuery] int season,[FromQuery] string? team, [FromQuery] string? position, [FromQuery] int pa = 1)
        {
            var query = await _context.Masterhitting
            .Join(_context.Teams,
            hitting => hitting.TeamId,
            team => team.TeamId,
            (hitting, team) => (new HittingSeason {
                    Player = hitting.Player,
                    PlayerId = hitting.PlayerId,
                    TeamId = hitting.TeamId,
                    Name = team.Name,
                    Season = hitting.Season,
                    Hr = hitting.Hr,
                    Rbi = hitting.Rbi,
                    Tb = hitting.Tb,
                    Tpa = hitting.Tpa,
                    H = hitting.H,
                    Bb = hitting.Bb,
                    So = hitting.So,
                    D = hitting.D,
                    Hbp = hitting.Hbp,
                    Cs = hitting.Cs,
                    Obp = hitting.Obp,
                    Ibb = hitting.Ibb,
                    Ab = hitting.Ab,
                    S = hitting.S,
                    Sb = hitting.Sb,
                    Woba = hitting.Woba,
                    G = hitting.G,
                    Avg = hitting.Avg,
                    Ops = hitting.Ops,
                    R = hitting.R,
                    Slg = hitting.Slg,
                    NameAbbrev = team.NameAbbrev,
                    LeagueAbbrev = team.LeagueAbbrev,
                    PrimaryPosition = hitting.PrimaryPosition
            }))
            .Where(
            obj => obj.Season == season 
                && obj.Tpa > pa
                && (team == null || obj.TeamId == team)
                && (position == null || position == "ALLOF"?obj.PrimaryPosition.Contains("F"):obj.PrimaryPosition == position))
            .OrderByDescending(obj => obj.Woba)
            .ToListAsync();
            return query;
        }
        // GET: api/hitching/641355
        [HttpGet("{player}")]
        public async Task<ActionResult<IEnumerable<Masterhitting>>> GetPlayerHitting(string player)
        {
            var query = await _context.Masterhitting
            .Where(
            obj => obj.PlayerId == player)
            .OrderBy(obj => obj.Season)
            .ToListAsync();
            return query;
        }

        // PUT: api/Hitting/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMasterhitting(int id, Masterhitting masterhitting)
        {
            if (id != masterhitting.Id)
            {
                return BadRequest();
            }

            _context.Entry(masterhitting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MasterhittingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Hitting
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Masterhitting>> PostMasterhitting(Masterhitting masterhitting)
        {
            _context.Masterhitting.Add(masterhitting);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMasterhitting", new { id = masterhitting.Id }, masterhitting);
        }

        // DELETE: api/Hitting/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Masterhitting>> DeleteMasterhitting(int id)
        {
            var masterhitting = await _context.Masterhitting.FindAsync(id);
            if (masterhitting == null)
            {
                return NotFound();
            }

            _context.Masterhitting.Remove(masterhitting);
            await _context.SaveChangesAsync();

            return masterhitting;
        }

        private bool MasterhittingExists(int id)
        {
            return _context.Masterhitting.Any(e => e.Id == id);
        }
    }
}
