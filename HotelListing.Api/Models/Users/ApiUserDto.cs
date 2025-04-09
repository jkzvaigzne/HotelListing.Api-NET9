﻿using System.ComponentModel.DataAnnotations;

namespace HotelListing.Api.Models.Users
{
    public class ApiUserDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Your Password is limited to {2} to {1} characters",
         MinimumLength = 6)]
        public string Password { get; set; }
    }
}