using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerAging
{
    public string Serial { get; set; } = null!;

    public string? ProductCode { get; set; }

    public string? DeptName1 { get; set; }

    public string? DeptName2 { get; set; }

    public string? DeptName3 { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public DateOnly? ImportDate { get; set; }

    public string? InStockAt { get; set; }

    public string? WareHouseName { get; set; }

    public DateOnly? LastStockDate { get; set; }

    public string? LastTransType { get; set; }

    public string? ProductionStatus { get; set; }

    public bool? Hold { get; set; }
}
