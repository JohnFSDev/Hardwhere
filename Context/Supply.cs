using System;
using System.Collections.Generic;

namespace Hardwhere_API.Context;

public partial class Supply
{
    public int IdSupply { get; set; }

    public string ConnectorType { get; set; } = null!;

    public string Wattage { get; set; } = null!;

    public string MinimumInput { get; set; } = null!;

    public string UrlImg { get; set; } = null!;

    public int IdComponents { get; set; }

    public virtual Component IdComponentsNavigation { get; set; } = null!;
}
