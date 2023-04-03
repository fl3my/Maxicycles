﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Maxicycles.Data;

public class MaxicyclesDbContext : IdentityDbContext
{
    public MaxicyclesDbContext(DbContextOptions<MaxicyclesDbContext> options)
        : base(options)
    {
    }
}