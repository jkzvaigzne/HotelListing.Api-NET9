using HotelListing.Api.Models.Hotels;

namespace HotelListing.Api.Models.Country
{
    public class CountryDto : BaseCountryDto
    {
        public int Id { get; set; }
        public List<HotelDto> Hotels { get; set; }
    }
}
