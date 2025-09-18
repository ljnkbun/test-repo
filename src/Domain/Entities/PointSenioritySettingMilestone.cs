using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointSenioritySettingMilestone
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

    public string? SenioritySettingCode { get; set; }

    public decimal? SeniorityFrom { get; set; }

    public decimal? CoinValue { get; set; }

    public decimal? PointValue { get; set; }

    public string? Source { get; set; }

    public int? SenioritySettingId { get; set; }

    public virtual PointSenioritySetting? SenioritySetting { get; set; }
}
