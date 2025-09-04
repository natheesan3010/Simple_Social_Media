using System;
using Friend.Entities;
using Microsoft.EntityFrameworkCore;

namespace Friend.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options) // constructor
{
    public DbSet<AppUser> Users { get; set; } // DbSet for AppUser
} // class
