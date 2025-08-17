using MeetingMinutesAPI.Data;
using MeetingMinutesAPI.Interfaces;
using MeetingMinutesAPI.Models.DTOs;
using MeetingMinutesAPI.Models.Entities;

namespace MeetingMinutesAPI.Repositories
{
    public class MeetingMinutesRepository: IMeetingMinutesRepository
    {
        private readonly AppDbContext _context;
        public MeetingMinutesRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<int> SaveMeetingMinutesAsync(MeetingMinutesRequest request)
        {
            if (request == null || request.Details == null || !request.Details.Any())
                throw new ArgumentException("Invalid request");

            var master = new MeetingMinutesMaster
            {
                CustomerType = request.CustomerType,
                MeetingDate = request.MeetingDate,
                MeetingTime = request.MeetingTime,
                CorporateId = request.CustomerType == "Corporate" ? request.CustomerId : null,
                IndividualId = request.CustomerType == "Individual" ? request.CustomerId : null,
                MeetingPlace = request.MeetingPlace,
                AttendsFromClient = request.AttendsFromClient,
                AttendsFromHost = request.AttendsFromHost,
                MeetingAgenda = request.MeetingAgenda,
                MeetingDiscussion = request.MeetingDiscussion,
                MeetingDecision = request.MeetingDecision,
                Details = request.Details.Select(d => new MeetingMinutesDetails
                {
                    ProductId = d.ProductId,
                    Quantity = d.Quantity,
                    Unit = d.Unit
                }).ToList()
            };

            _context.MeetingMinutesMasters.Add(master);
            await _context.SaveChangesAsync();

            return master.MasterId;


        }
    }
    
}
