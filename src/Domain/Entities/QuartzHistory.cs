using System;
using System.Collections.Generic;

namespace Infra;

public partial class QuartzHistory
{
    public long Id { get; set; }

    public DateTime CreationTime { get; set; }

    public int State { get; set; }

    public string? JobName { get; set; }

    public string? Group { get; set; }

    public string? Exception { get; set; }

    public string? FireInstanceId { get; set; }

    public DateTime FireTimeUtc { get; set; }

    public string? Description { get; set; }

    public TimeOnly JobRunTime { get; set; }

    public int? TenantId { get; set; }

    public DateTime NextRunTime { get; set; }
}
