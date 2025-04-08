using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.Api.Models.Hotels
{
    public class HotelDto : BaseHotelDto
    {
        public int Id { get; set; }
    }
}
