using System;
using System.Collections.Generic;

namespace Infra;

public partial class PromoRewardRedemptionItem
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

    public int RedemptionRequestId { get; set; }

    public int RewardItemId { get; set; }

    public string? RewardItemCode { get; set; }

    public int Quantity { get; set; }

    public int ToTalQuantityUsed { get; set; }

    public string? Uom { get; set; }

    public string? Status { get; set; }

    public DateTime? UsedDate { get; set; }
}
