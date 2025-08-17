using MeetingMinutesAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeetingMinutesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CustomerController(AppDbContext context)
        {
            _context = context;
        }

        // GET api/customer/corporate
        [HttpGet("corporate")]
        public async Task<IActionResult> GetCorporateCustomers()
        {
            var corporates = await _context.CorporateCustomers
                .AsNoTracking()
                .Select(c => new { value = c.CorporateId, text = c.CorporateName })
                .ToListAsync();

            return Ok(corporates);
        }


        // GET api/customer/individual
        [HttpGet("individual")]
        public async Task<IActionResult> GetIndividualCustomers()
        {
            var individuals = await _context.IndividualCustomers
                .AsNoTracking()
                .Select(i => new { value = i.IndividualId, text = i.Name })
                .ToListAsync();

            return Ok(individuals);
        }
    }
}
