namespace MeetingMinutesAPI.Models.DTOs
{
    public class MeetingMinutesRequest
    {
        public string CustomerType { get; set; } 
        public int CustomerId { get; set; }
        public DateTime MeetingDate { get; set; }
        public string MeetingTime { get; set; }

        public string MeetingPlace { get; set; }
        public string AttendsFromClient { get; set; }
        public string AttendsFromHost { get; set; }
        public string MeetingAgenda { get; set; }
        public string MeetingDiscussion { get; set; }
        public string MeetingDecision { get; set; }

        public List<MeetingMinutesDetailDto> Details { get; set; }
    }
}
