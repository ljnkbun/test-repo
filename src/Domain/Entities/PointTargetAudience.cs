using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointTargetAudience
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

    public bool IsActive { get; set; }

    public string? Type { get; set; }

    public string? Description { get; set; }

    public int Count { get; set; }

    public bool IsFilterProfile { get; set; }

    public string? Source { get; set; }

    public virtual ICollection<PointActionRuleSetting> PointActionRuleSettings { get; set; } = new List<PointActionRuleSetting>();

    public virtual ICollection<PointBaseSetting> PointBaseSettings { get; set; } = new List<PointBaseSetting>();

    public virtual ICollection<PointEventSetting> PointEventSettings { get; set; } = new List<PointEventSetting>();

    public virtual ICollection<PointEventSubscriptionHeader> PointEventSubscriptionHeaders { get; set; } = new List<PointEventSubscriptionHeader>();

    public virtual ICollection<PointGift> PointGifts { get; set; } = new List<PointGift>();

    public virtual ICollection<PointNonPurchaseSetting> PointNonPurchaseSettings { get; set; } = new List<PointNonPurchaseSetting>();

    public virtual ICollection<PointProductCategorySetting> PointProductCategorySettings { get; set; } = new List<PointProductCategorySetting>();

    public virtual ICollection<PointProductSetting> PointProductSettings { get; set; } = new List<PointProductSetting>();

    public virtual ICollection<PointReferralSetting> PointReferralSettingRefereeTargetAudiences { get; set; } = new List<PointReferralSetting>();

    public virtual ICollection<PointReferralSetting> PointReferralSettingReferrerTargetAudiences { get; set; } = new List<PointReferralSetting>();

    public virtual ICollection<PointSenioritySetting> PointSenioritySettings { get; set; } = new List<PointSenioritySetting>();

    public virtual ICollection<PointTargetAudienceDetail> PointTargetAudienceDetails { get; set; } = new List<PointTargetAudienceDetail>();
}
