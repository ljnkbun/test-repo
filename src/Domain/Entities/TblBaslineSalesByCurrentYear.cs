using System;
using System.Collections.Generic;

namespace Infra;

public partial class TblBaslineSalesByCurrentYear
{
    public string? MemberCode { get; set; }

    public decimal? Point { get; set; }

    public decimal? Coin { get; set; }

    public string? DepartmentLevel1 { get; set; }

    public string? SaleType { get; set; }

    public int? RankId { get; set; }

    public int? YearTime { get; set; }
}
