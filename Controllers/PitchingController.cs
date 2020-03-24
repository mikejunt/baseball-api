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
    public class PitchingController : ControllerBase
    {
        private readonly baseballdbContext _context;

        public PitchingController(baseballdbContext context)
        {
            _context = context;
        }

        // GET: api/Pitching?season=2019
        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<PitchingSeason>>> GetSeasonPitching([FromQuery] int season,[FromQuery] string? team, [FromQuery] int ip = 1)
        {
            var query = await _context.Masterpitching
            .Join(_context.Teams,
            pitching => pitching.TeamId,
            team => team.TeamId,
            (pitching, team) => (new PitchingSeason {
                    Player = pitching.Player,
                    PlayerId = pitching.PlayerId,
                    TeamId = pitching.TeamId,
                    Name = team.Name,
                    Season = pitching.Season,
                    Gidp = pitching.Gidp,
                    Np = pitching.Np,
                    Sho = pitching.Sho,
                    Bk = pitching.Bk,
                    Sv = pitching.Sv,
                    Bb = pitching.Bb,
                    So = pitching.So,
                    Wp = pitching.Wp,
                    Hb = pitching.Hb,
                    Rs = pitching.Rs,
                    L = pitching.L,
                    Cg = pitching.Cg,
                    Gs = pitching.Gs,
                    Ibb = pitching.Ibb,
                    Hr = pitching.Hr,
                    Era = pitching.Era,
                    Fip = pitching.Fip,
                    Hld = pitching.Hld,
                    G = pitching.G,
                    Ip = pitching.Ip,
                    W = pitching.W,
                    R = pitching.R,
                    Er = pitching.Er,
                    NameAbbrev = team.NameAbbrev,
                    LeagueAbbrev = team.LeagueAbbrev
            }))
            .Where(
            obj => obj.Season == season 
                && obj.Ip > ip
                && (team == null || obj.TeamId == team))
            .OrderBy(obj => obj.Fip)
            .ToListAsync();
            return query;
        }

        // GET: api/Pitching/477132
        [HttpGet("{player}")]
        public async Task<ActionResult<IEnumerable<Masterpitching>>> GetPlayerPitching(string player)
        {
            var query = await _context.Masterpitching
            .Where(
            obj => obj.PlayerId == player)
            .OrderBy(obj => obj.Season)
            .ToListAsync();
            return query;
        }

        // PUT: api/Pitching/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMasterpitching(int id, Masterpitching masterpitching)
        {
            if (id != masterpitching.Id)
            {
                return BadRequest();
            }

            _context.Entry(masterpitching).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MasterpitchingExists(id))
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

        // POST: api/Pitching
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Masterpitching>> PostMasterpitching(Masterpitching masterpitching)
        {
            _context.Masterpitching.Add(masterpitching);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMasterpitching", new { id = masterpitching.Id }, masterpitching);
        }

        // DELETE: api/Pitching/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Masterpitching>> DeleteMasterpitching(int id)
        {
            var masterpitching = await _context.Masterpitching.FindAsync(id);
            if (masterpitching == null)
            {
                return NotFound();
            }

            _context.Masterpitching.Remove(masterpitching);
            await _context.SaveChangesAsync();

            return masterpitching;
        }

        private bool MasterpitchingExists(int id)
        {
            return _context.Masterpitching.Any(e => e.Id == id);
        }
    }
}
