using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointCoinExpirationSetting
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

    public string? Code { get; set; }

    public bool IsActive { get; set; }

    public string? ValidCoinType { get; set; }

    public int? ValidCoinMonths { get; set; }

    public int? ValidCoinPeriodDuration { get; set; }

    public int? ValidCoinPeriodExtendMonths { get; set; }

    public DateTime? ValidCoinPeriodStartMonth { get; set; }

    public string? Source { get; set; }

    public int? ValidCoinDays { get; set; }

    public string? Cron { get; set; }

    public string? Timezone { get; set; }

    public int? CalculationPeriodDuration { get; set; }

    public DateTime? CalculationPeriodStartMonth { get; set; }

    public string? CalculationType { get; set; }
}
