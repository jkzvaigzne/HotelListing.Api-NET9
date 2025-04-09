﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Api.Data
{
    public class HotelListingDbContext : IdentityDbContext<ApiUser>
    {
        public HotelListingDbContext(DbContextOptions<HotelListingDbContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
