using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerOutletRevenueBaseline
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public int TenantId { get; set; }

    public string? OutletCode { get; set; }

    public string? OutletName { get; set; }

    public decimal? Target { get; set; }

    public decimal? Actual { get; set; }

    public decimal? Bonus { get; set; }

    public long? CumulatedMonth { get; set; }

    public long? UpdatedDate { get; set; }
}
