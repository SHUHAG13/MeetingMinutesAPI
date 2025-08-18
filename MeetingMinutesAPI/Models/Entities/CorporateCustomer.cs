using System.ComponentModel.DataAnnotations;

namespace MeetingMinutesAPI.Models.Entities
{
    public class CorporateCustomer
    {
        [Key]
        public int CorporateId { get; set; }

        [Required, StringLength(150)]
        public string Name { get; set; }
    }
}
