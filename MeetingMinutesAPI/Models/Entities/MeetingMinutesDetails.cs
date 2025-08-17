using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetingMinutesAPI.Models.Entities
{
    public class MeetingMinutesDetails
    {
        [Key]
        public int DetailId { get; set; }

        [Required, ForeignKey("MeetingMinutesMaster")]

        public int MasterId { get; set; }
        public MeetingMinutesMaster Master { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required, StringLength(50)]
        public string Unit { get; set; }
    }
}
