using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bank_WebAPI.Models;

namespace Bank_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly BankDBContext _context;

        public UserController(BankDBContext context)
        {
            _context = context;
        }

        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<b_user>>> Getb_Users()
        {
          if (_context.b_Users == null)
          {
              return NotFound();
          }
            return await _context.b_Users.ToListAsync();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<b_user>> Getb_user(int id)
        {
          if (_context.b_Users == null)
          {
              return NotFound();
          }
            var b_user = await _context.b_Users.FindAsync(id);

            if (b_user == null)
            {
                return NotFound();
            }

            return b_user;
        }

        // PUT: api/User/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putb_user(int id, b_user b_user)
        {
            if (id != b_user.id)
            {
                return BadRequest();
            }

            _context.Entry(b_user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!b_userExists(id))
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

        // POST: api/User
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<b_user>> Postb_user(b_user b_user)
        {
          if (_context.b_Users == null)
          {
              return Problem("Entity set 'BankDBContext.b_Users'  is null.");
          }
            _context.b_Users.Add(b_user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getb_user", new { id = b_user.id }, b_user);
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteb_user(int id)
        {
            if (_context.b_Users == null)
            {
                return NotFound();
            }
            var b_user = await _context.b_Users.FindAsync(id);
            if (b_user == null)
            {
                return NotFound();
            }

            _context.b_Users.Remove(b_user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool b_userExists(int id)
        {
            return (_context.b_Users?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
