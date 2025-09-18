using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointTransactionPointBaseLine
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

    public string MemberCode { get; set; } = null!;

    public int Month { get; set; }

    public decimal Point { get; set; }

    public string? Source { get; set; }

    public int? ConsumerId { get; set; }
}
