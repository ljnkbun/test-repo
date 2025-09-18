using System;
using System.Collections.Generic;

namespace Infra;

public partial class BackgroundJob
{
    public long Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public string JobType { get; set; } = null!;

    public string JobArgs { get; set; } = null!;

    public short TryCount { get; set; }

    public DateTime NextTryTime { get; set; }

    public DateTime? LastTryTime { get; set; }

    public bool IsAbandoned { get; set; }

    public byte Priority { get; set; }
}
