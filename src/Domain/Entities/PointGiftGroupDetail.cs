using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointGiftGroupDetail
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

    public string? GiftGroupCode { get; set; }

    public string? GiftCode { get; set; }

    public string? Status { get; set; }

    public int? GiftGroupId { get; set; }

    public int? GiftId { get; set; }

    public string? Source { get; set; }

    public virtual PointGift? Gift { get; set; }

    public virtual PointGiftGroup? GiftGroup { get; set; }
}
