using HotelListing.Api.Models.Users;
using Microsoft.AspNetCore.Identity;
using System.Collections;

namespace HotelListing.Api.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
    }
}
