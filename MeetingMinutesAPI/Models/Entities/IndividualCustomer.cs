using System.ComponentModel.DataAnnotations;

namespace MeetingMinutesAPI.Models.Entities
{
    public class IndividualCustomer
    {
        [Key]
        public int IndividualId { get; set; }

        [Required, StringLength(150)]
        public string Name { get; set; }
    }
}
