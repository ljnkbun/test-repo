using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointPeriodHistory
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int? TenantId { get; set; }

    public DateTime StartPeriod { get; set; }

    public DateTime EndPeriod { get; set; }

    public bool IsActive { get; set; }

    public int Type { get; set; }

    public string? Source { get; set; }

    public DateTime? ExtendPeriodMonth { get; set; }
}
