using System.ComponentModel.DataAnnotations;

namespace MeetingMinutesAPI.Models.Entities
{
    public class MeetingMinutesMaster
    {
        [Key]
        public int MasterId { get; set; }

        [Required]
        public string CustomerType { get; set; } 

        public int? CorporateId { get; set; }
        public int? IndividualId { get; set; }

        [Required]
        public DateTime MeetingDate { get; set; }

        [Required]
        public string MeetingTime { get; set; }

        [Required, StringLength(200)]
        public string MeetingPlace { get; set; }

        [StringLength(300)]
        public string AttendsFromClient { get; set; }

        [StringLength(300)]
        public string AttendsFromHost { get; set; }

        [Required, StringLength(500)]
        public string MeetingAgenda { get; set; }
        [Required, StringLength(1000)]
        public string MeetingDiscussion { get; set; }
        [Required, StringLength(500)]
        public string MeetingDecision { get; set; }

        public ICollection<MeetingMinutesDetails> Details { get; set; }
    }
}
