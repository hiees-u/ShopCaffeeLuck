using System;
using System.Collections.Generic;

namespace ShopCaffeeLuckAPIs.Model;

public partial class Product
{
    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ProductId { get; set; }

    public string? Description1 { get; set; }

    public decimal? Price { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();

    public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();
}
