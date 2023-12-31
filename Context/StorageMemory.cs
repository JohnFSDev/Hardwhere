using System;
using System.Collections.Generic;

namespace Hardwhere_API.Context;

public partial class StorageMemory
{
    public int Id { get; set; }

    public string Storage { get; set; } = null!;

    public string ConnectivityTech { get; set; } = null!;

    public string UrlImg { get; set; } = null!;

    public int IdComponents { get; set; }

    public virtual Component IdComponentsNavigation { get; set; } = null!;
}
