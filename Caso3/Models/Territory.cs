using System;
using System.Collections.Generic;

namespace Caso3.Models;

public partial class Territory
{
    public int IdTerritory { get; set; }

    public string? Description { get; set; }

    public string? Area { get; set; }

    public string? Population { get; set; }
}
