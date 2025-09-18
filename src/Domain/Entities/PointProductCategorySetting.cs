using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointProductCategorySetting
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

    public string? Description { get; set; }

    public DateTime EffectiveFrom { get; set; }

    public DateTime EffectiveTo { get; set; }

    public bool IsActive { get; set; }

    public int? TargetAudienceId { get; set; }

    public decimal CoinValue { get; set; }

    public decimal PointValue { get; set; }

    public int? Count { get; set; }

    public int CampaignId { get; set; }

    public string? TargetAudienceCode { get; set; }

    public string? Source { get; set; }

    public virtual PointCampaign Campaign { get; set; } = null!;

    public virtual ICollection<PointProductCategorySettingDetail> PointProductCategorySettingDetails { get; set; } = new List<PointProductCategorySettingDetail>();

    public virtual PointTargetAudience? TargetAudience { get; set; }
}
