using System;
using System.Collections.Generic;

namespace ShopCaffeeLuckAPIs.Model;

public partial class Cart
{
    public int UserId { get; set; }

    public int ProductId { get; set; }

    public int SoL { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
