using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointGiftRedeemTransaction
{
    public long Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int? TenantId { get; set; }

    public string Code { get; set; } = null!;

    public string? MemberCode { get; set; }

    public string? GiftCode { get; set; }

    public string? GiftName { get; set; }

    public string? EgiftCode { get; set; }

    public decimal Quantity { get; set; }

    public string? Status { get; set; }

    public int? MemberId { get; set; }

    public int? GiftId { get; set; }

    public string? Source { get; set; }

    public DateTime? Date { get; set; }

    public string? EgiftStatus { get; set; }

    public string? Description { get; set; }

    public float? Coin { get; set; }

    public float? TotalCoin { get; set; }

    public virtual PointGift? Gift { get; set; }

    public virtual PointMember? Member { get; set; }
}
