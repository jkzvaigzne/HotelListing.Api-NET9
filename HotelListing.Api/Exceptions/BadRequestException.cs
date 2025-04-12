namespace HotelListing.Api.Exceptions
{
    public class BadRequestException : ApplicationException
    {
        public BadRequestException(string name, object key) : base($"Invalid request for resource {name} with identifier {key}.")
        {

        }
    }
}
