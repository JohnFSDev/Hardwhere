using System;
using System.Collections.Generic;

namespace Hardwhere_API.Context;

public partial class Component
{
    public int IdComponents { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Brand { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int Consults { get; set; }

    public virtual GraphicCard? GraphicCard { get; set; }

    public virtual Processor? Processor { get; set; }

    public virtual Ram? Ram { get; set; }

    public virtual StorageMemory? StorageMemory { get; set; }

    public virtual Supply? Supply { get; set; }
}
