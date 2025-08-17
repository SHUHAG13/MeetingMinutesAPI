using MeetingMinutesAPI.Models.DTOs;

namespace MeetingMinutesAPI.Interfaces
{
    public interface IMeetingMinutesRepository
    {
        Task<int> SaveMeetingMinutesAsync(MeetingMinutesRequest request);
    }
}
