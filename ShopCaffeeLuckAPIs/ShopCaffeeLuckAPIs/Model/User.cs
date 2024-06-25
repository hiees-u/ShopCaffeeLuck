using System;
using System.Collections.Generic;

namespace ShopCaffeeLuckAPIs.Model;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserPass { get; set; } = null!;

    public string? FullName { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();
}
