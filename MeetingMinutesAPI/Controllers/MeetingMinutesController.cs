using MeetingMinutesAPI.Data;
using MeetingMinutesAPI.Models.DTOs;
using MeetingMinutesAPI.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeetingMinutesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingMinutesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MeetingMinutesController(AppDbContext context)
        {
            _context = context;
        }



        [HttpPost]
        public async Task<IActionResult> SaveMeetingMinutes([FromBody] MeetingMinutesRequest request)
        {
            if (request == null || request.Details == null || !request.Details.Any())
                return BadRequest("Invalid request");

            var master = new MeetingMinutesMaster
            {
                CustomerType = request.CustomerType,
                MeetingDate = request.MeetingDate,
                MeetingTime = request.MeetingTime,
                CorporateId = request.CustomerType == "Corporate" ? request.CustomerId : null,
                IndividualId = request.CustomerType == "Individual" ? request.CustomerId : null,
                MeetingPlace= request.MeetingPlace,
                AttendsFromClient = request.AttendsFromClient,
                AttendsFromHost = request.AttendsFromHost,
                MeetingAgenda = request.MeetingAgenda,
                MeetingDiscussion = request.MeetingDiscussion,
                MeetingDecision= request.MeetingDecision,
                Details = request.Details.Select(d => new MeetingMinutesDetails
                {
                    ProductId = d.ProductId,
                    Quantity = d.Quantity,
                    Unit = d.Unit
                }).ToList()
            };

            _context.MeetingMinutesMasters.Add(master);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Meeting Minutes saved successfully", masterId = master.MasterId });
        }
    }
}
