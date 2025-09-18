using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointRedemptionOverview
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

    public int Month { get; set; }

    public int Year { get; set; }

    public string? ReasonCode { get; set; }

    public string? ReasonName { get; set; }

    public decimal Coin { get; set; }

    public DateTime CalculateDate { get; set; }
}
