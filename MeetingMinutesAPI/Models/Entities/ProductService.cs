using System.ComponentModel.DataAnnotations;

namespace MeetingMinutesAPI.Models.Entities
{
    public class ProductService
    {
        [Key]
        public int ProductId { get; set; }

        [Required, StringLength(150)]
        public string ProductName { get; set; }

        [Required, StringLength(50)]
        public string Unit { get; set; }
    }
}
