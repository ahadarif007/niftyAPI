using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using niftyAPI.Models;

namespace niftyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Api_2 : ControllerBase
    {
        private readonly AppDbContext _context;

        public Api_2(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Api_2/
        [HttpGet]
        public async Task<ActionResult<IEnumerable<History>>> GetHistory()
        {
            return await _context.History.ToListAsync();
        }

        // GET: api/Api_2/5
        [HttpGet("{id}")]
        public async Task<ActionResult<History>> GetHistory(int id)
        {
            var history = await _context.History.FindAsync(id);

            if (history == null)
            {
                return NotFound();
            }

            return history;
        }
    }
}
