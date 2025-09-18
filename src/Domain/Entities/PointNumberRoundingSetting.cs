using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointNumberRoundingSetting
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

    public string Code { get; set; } = null!;

    public int? Type { get; set; }

    public bool IsActive { get; set; }

    public DateTime? SavingPeriodStartMonth { get; set; }

    public int? SavingPeriodDuration { get; set; }

    public string? Source { get; set; }
}
