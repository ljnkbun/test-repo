using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointCampaign
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

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public DateTime EffectiveFrom { get; set; }

    public DateTime EffectiveTo { get; set; }

    public decimal EstimatedMembers { get; set; }

    public decimal EstimatedBudget { get; set; }

    public decimal EstimatedRevenue { get; set; }

    public string? Approver { get; set; }

    public DateTime? ApproveDate { get; set; }

    public int? ApproveUserId { get; set; }

    public string? Source { get; set; }

    public string? CampaignType { get; set; }

    public virtual ICollection<PointActionRuleSetting> PointActionRuleSettings { get; set; } = new List<PointActionRuleSetting>();

    public virtual ICollection<PointBaseSetting> PointBaseSettings { get; set; } = new List<PointBaseSetting>();

    public virtual ICollection<PointEventSetting> PointEventSettings { get; set; } = new List<PointEventSetting>();

    public virtual ICollection<PointNonPurchaseSetting> PointNonPurchaseSettings { get; set; } = new List<PointNonPurchaseSetting>();

    public virtual ICollection<PointProductCategorySetting> PointProductCategorySettings { get; set; } = new List<PointProductCategorySetting>();

    public virtual ICollection<PointProductSetting> PointProductSettings { get; set; } = new List<PointProductSetting>();

    public virtual ICollection<PointRankSetting> PointRankSettings { get; set; } = new List<PointRankSetting>();

    public virtual ICollection<PointReferralSetting> PointReferralSettings { get; set; } = new List<PointReferralSetting>();

    public virtual ICollection<PointReferralTransaction> PointReferralTransactions { get; set; } = new List<PointReferralTransaction>();

    public virtual ICollection<PointSenioritySetting> PointSenioritySettings { get; set; } = new List<PointSenioritySetting>();
}
