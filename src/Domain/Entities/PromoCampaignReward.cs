using System;
using System.Collections.Generic;

namespace Infra;

public partial class PromoCampaignReward
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int TenantId { get; set; }

    public int RewardId { get; set; }

    public int CampaignId { get; set; }

    public DateTime? EffectFrom { get; set; }

    public DateTime? EffectTo { get; set; }

    public int LimitQuantity { get; set; }
}
