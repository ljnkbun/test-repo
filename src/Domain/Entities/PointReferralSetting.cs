using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointReferralSetting
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

    public DateTime EffectiveFrom { get; set; }

    public DateTime EffectiveTo { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public decimal ExpiredDays { get; set; }

    public decimal OrderAmountRequired { get; set; }

    public decimal MaxSet { get; set; }

    public decimal ReferrerPoint { get; set; }

    public decimal ReferrerCoin { get; set; }

    public decimal RefereePoint { get; set; }

    public decimal RefereeCoin { get; set; }

    public int? ReferrerTargetAudienceId { get; set; }

    public int? RefereeTargetAudienceId { get; set; }

    public int? CampaignId { get; set; }

    public string? Source { get; set; }

    public virtual PointCampaign? Campaign { get; set; }

    public virtual PointTargetAudience? RefereeTargetAudience { get; set; }

    public virtual PointTargetAudience? ReferrerTargetAudience { get; set; }
}
