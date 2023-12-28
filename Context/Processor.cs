using System;
using System.Collections.Generic;

namespace Hardwhere_API.Context;

public partial class Processor
{
    public int IdProcessor { get; set; }

    public string Cpu { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string Speed { get; set; } = null!;

    public string UrlImg { get; set; } = null!;

    public int IdComponents { get; set; }

    public virtual Component IdComponentsNavigation { get; set; } = null!;
}
