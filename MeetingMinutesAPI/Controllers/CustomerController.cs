using MeetingMinutesAPI.Data;
using MeetingMinutesAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeetingMinutesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerRepository _repository;

        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }


        // GET api/customer/corporate
        [HttpGet("corporate")]
        public async Task<IActionResult> GetCorporateCustomers()
        {
            var corporates = await _repository.GetCorporateCustomersAsync();
            return Ok(corporates);
        }



        // GET api/customer/individual
        [HttpGet("individual")]
        public async Task<IActionResult> GetIndividualCustomers()
        {
            var individuals = await _repository.GetIndividualCustomersAsync();
            return Ok(individuals);
        }

    }
}
