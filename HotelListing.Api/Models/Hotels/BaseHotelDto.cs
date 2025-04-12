using System.ComponentModel.DataAnnotations;

namespace HotelListing.Api.Models.Hotels
{
    public abstract class BaseHotelDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        // If don't provide nothing accept null 
        public double? Rating { get; set; }
        [Required]
        //[Range(1, int.MaxValue)]
        public int CountryId { get; set; }
    }
}
