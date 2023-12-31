using System;
using System.Collections.Generic;

namespace Hardwhere_API.Context;

public partial class Ram
{
    public int Id { get; set; }

    public string RamSize { get; set; } = null!;

    public string RamTech { get; set; } = null!;

    public string RamSpeed { get; set; } = null!;

    public string UrlImg { get; set; } = null!;

    public int IdComponents { get; set; }

    public virtual Component IdComponentsNavigation { get; set; } = null!;
}
