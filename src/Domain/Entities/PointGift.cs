using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointGift
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

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Introduce { get; set; }

    public string? FullGiftCategoryCode { get; set; }

    public string? Producer { get; set; }

    public string? Vendor { get; set; }

    public DateTime EffectiveFrom { get; set; }

    public DateTime EffectiveTo { get; set; }

    public decimal RequiredCoin { get; set; }

    public string? Status { get; set; }

    public decimal TotalQuantity { get; set; }

    public decimal UsedQuantity { get; set; }

    public decimal RemainingQuantity { get; set; }

    public bool IsEgift { get; set; }

    public string? Tag { get; set; }

    public string? ReferenceCode { get; set; }

    public int? TargetAudienceId { get; set; }

    public int? GiftGroupId { get; set; }

    public decimal? Amount { get; set; }

    public string? GiftType { get; set; }

    public string? TargetAudienceType { get; set; }

    public int? GiftTargetAudienceId { get; set; }

    public virtual PointGiftGroup? GiftGroup { get; set; }

    public virtual ICollection<PointEgift> PointEgifts { get; set; } = new List<PointEgift>();

    public virtual ICollection<PointGiftGroupDetail> PointGiftGroupDetails { get; set; } = new List<PointGiftGroupDetail>();

    public virtual ICollection<PointGiftRedeemTransaction> PointGiftRedeemTransactions { get; set; } = new List<PointGiftRedeemTransaction>();

    public virtual PointTargetAudience? TargetAudience { get; set; }
}
