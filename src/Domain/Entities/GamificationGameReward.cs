using System;
using System.Collections.Generic;

namespace Infra;

public partial class GamificationGameReward
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

    public string? GameCode { get; set; }

    public string? RewardCode { get; set; }

    public string? RewardNameEn { get; set; }

    public string? RewardNameVn { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Status { get; set; }

    public string? ImageLink { get; set; }

    public string? Description { get; set; }

    public decimal? Order { get; set; }

    public decimal? WeightRatio { get; set; }

    public decimal? Budget { get; set; }

    public decimal? UsedBudget { get; set; }

    public decimal? MaxPerPlayer { get; set; }

    public string? ItemCode { get; set; }

    public string? RewardType { get; set; }

    public string? RewardPartner { get; set; }

    public string? VendorCode { get; set; }

    public decimal? Amount { get; set; }
}
