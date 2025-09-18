using System;
using System.Collections.Generic;

namespace Infra;

public partial class LogMt
{
    public DateTime CreationTime { get; set; }

    public string Serial { get; set; } = null!;

    public bool IsMt { get; set; }
}
