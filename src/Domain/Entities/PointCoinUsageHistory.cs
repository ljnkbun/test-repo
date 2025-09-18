using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointCoinUsageHistory
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

    public int? ConsumerId { get; set; }

    public string? MemberCode { get; set; }

    public string? TransactionCode { get; set; }

    public DateTime? BusinessTime { get; set; }

    public long? TransactionCoinBaselineId { get; set; }

    public decimal? CoinUsed { get; set; }

    public decimal? LastCoin { get; set; }

    public string? Reason { get; set; }

    public string? Source { get; set; }
}
