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

            var corporates = await _context.CorporateCustomers.ToListAsync();

            return Ok(corporates);
        }


        // GET api/customer/individual
        [HttpGet("individual")]
        public async Task<IActionResult> GetIndividualCustomers()
        {
           
            var individuals = await _context.IndividualCustomers.ToListAsync();

            return Ok(individuals);
        }
    }
}
