﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MovieDatabase.Identity;
public class UserContext : IdentityUserContext<IdentityUser>
{
    public UserContext(DbContextOptions<UserContext> options)
        : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}