namespace MeetingMinutesAPI.Models.DTOs
{
    public class MeetingMinutesRequest
    {
        public string CustomerType { get; set; } 
        public int CustomerId { get; set; }
        public DateTime MeetingDate { get; set; }
        public string MeetingTime { get; set; }
        public List<MeetingMinutesDetailDto> Details { get; set; }
    }
}
