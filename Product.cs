using System;
using System.Collections.Generic;

namespace ProductsMinimalAPI1070666.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int StockLevel { get; set; }

    public int CategoryId { get; set; }

    public bool OnSale { get; set; }

    public bool Discontinued { get; set; }

    public int? Pcolor { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ProductColor? PcolorNavigation { get; set; }
}
