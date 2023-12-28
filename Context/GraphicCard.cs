using System;
using System.Collections.Generic;

namespace Hardwhere_API.Context;

public partial class GraphicCard
{
    public int IdGraphic { get; set; }

    public string Coprocessor { get; set; } = null!;

    public string VramSize { get; set; } = null!;

    public string UrlImg { get; set; } = null!;

    public int IdComponents { get; set; }

    public virtual Component IdComponentsNavigation { get; set; } = null!;
}
