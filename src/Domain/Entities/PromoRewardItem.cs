using System;
using System.Collections.Generic;

namespace Infra;

public partial class PromoRewardItem
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

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? RewardType { get; set; }

    public decimal PointCost { get; set; }

    public decimal MonetaryValue { get; set; }

    public int AvailableQuantity { get; set; }

    public string? ImageUrl { get; set; }

    public bool IsActive { get; set; }
}
