using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointEgift
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

    public string? Type { get; set; }

    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public string? Status { get; set; }

    public string? UsedStatus { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public string? GiftCode { get; set; }

    public int? GiftId { get; set; }

    public string? Source { get; set; }

    public string? SerialCode { get; set; }

    public virtual PointGift? Gift { get; set; }
}
