using System;
using System.Collections.Generic;

namespace Infra;

public partial class AppFileStorage
{
    public long Id { get; set; }

    public DateTime CreationTime { get; set; }

    public string? FileName { get; set; }

    public string? FileContent { get; set; }
}
