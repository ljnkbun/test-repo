using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointTempCoinBaseline
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

    public decimal? Coin { get; set; }

    public string? MemberCode { get; set; }

    public string? BaselineData { get; set; }

    public string? Source { get; set; }

    public int? ConsumerId { get; set; }

    public DateTime? AvailableFrom { get; set; }

    public DateTime? AvailableTo { get; set; }

    public bool IsSync { get; set; }
}
