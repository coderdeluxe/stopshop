using System.ComponentModel.DataAnnotations;

namespace API.Dto
{
    public class AddressDto
    {
        [Required]
        public string Street { get; set; }
        [Required]
        public string Barangay { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Province { get; set; }
    }
}