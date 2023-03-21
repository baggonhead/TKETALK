using System;
using System.Collections.Generic;

namespace MainProject1.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Active { get; set; }

    public virtual ICollection<Task> Tasks { get; } = new List<Task>();
}
