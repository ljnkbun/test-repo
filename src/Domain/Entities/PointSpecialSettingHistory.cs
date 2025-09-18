using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointSpecialSettingHistory
{
    public int MemberId { get; set; }

    public string SpecialSettingCode { get; set; } = null!;

    public DateTime Date { get; set; }

    public int? TenantId { get; set; }

    public decimal CoinValue { get; set; }

    public decimal PointValue { get; set; }

    public string? Source { get; set; }

    public virtual PointMember Member { get; set; } = null!;
}
