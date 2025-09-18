using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointRankCalculationSetting
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

    public string? Cron { get; set; }

    public int? CalculationPeriodDuration { get; set; }

    public string? CalculationType { get; set; }

    public int? CalculationMonths { get; set; }

    public string? ValidType { get; set; }

    public int? ValidPeriodExtendMonths { get; set; }

    public int? ValidMonths { get; set; }

    public bool IsActive { get; set; }

    public DateTime? ValidPeriodStartMonth { get; set; }

    public DateTime? CalculationPeriodStartMonth { get; set; }

    public int? ValidPeriodDuration { get; set; }

    public string? TimeZone { get; set; }

    public string? Source { get; set; }
}
