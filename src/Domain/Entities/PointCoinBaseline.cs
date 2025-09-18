using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointCoinBaseline
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

    public string? MemberCode { get; set; }

    public int? Month { get; set; }

    public decimal? CoinGranted { get; set; }

    public decimal? CoinRedeemed { get; set; }

    public decimal? CoinAvailable { get; set; }
}
