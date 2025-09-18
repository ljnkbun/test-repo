using System;
using System.Collections.Generic;

namespace Infra;

public partial class QuartzJob
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public string? JobName { get; set; }

    public string? Group { get; set; }

    public int Status { get; set; }

    public string? Description { get; set; }

    public string? JobInfo { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public int? TenantId { get; set; }
}
