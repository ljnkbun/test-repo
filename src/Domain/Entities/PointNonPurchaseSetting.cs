using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointNonPurchaseSetting
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

    public string Name { get; set; } = null!;

    public int Type { get; set; }

    public string? Description { get; set; }

    public decimal CoinValue { get; set; }

    public decimal PointValue { get; set; }

    public DateTime EffectiveFrom { get; set; }

    public DateTime EffectiveTo { get; set; }

    public DateTime? Date { get; set; }

    public string? Cron { get; set; }

    public int OccurType { get; set; }

    public bool IsActive { get; set; }

    public int? TargetAudienceId { get; set; }

    public string? TimeZone { get; set; }

    public int? CampaignId { get; set; }

    public string? TargetAudienceCode { get; set; }

    public string? Source { get; set; }

    public virtual PointCampaign? Campaign { get; set; }

    public virtual PointTargetAudience? TargetAudience { get; set; }
}
