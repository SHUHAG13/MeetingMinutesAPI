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
        public ICollection<MeetingMinutesDetails> Details { get; set; }
    }
}
