using System;

namespace Friend.Entities;

public class AppUser
{
    public string Id { get; set; } = Guid.NewGuid().ToString(); // Guid: globally unique identifier
    public required string DisplayName { get; set; } 
    public required string Email { get; set; }
}
