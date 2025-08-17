using MeetingMinutesAPI.Data;
using MeetingMinutesAPI.Interfaces;
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
        private readonly IMeetingMinutesRepository _repository;

        public MeetingMinutesController(IMeetingMinutesRepository repository)
        {
            _repository = repository;
        }



        [HttpPost]
        public async Task<IActionResult> SaveMeetingMinutes([FromBody] MeetingMinutesRequest request)
        {
            if (request == null || request.Details == null || !request.Details.Any())
                return BadRequest("Invalid request");

            var masterId = await _repository.SaveMeetingMinutesAsync(request);

            return Ok(new { message = "Meeting Minutes saved successfully", masterId });
        }

    }
}
