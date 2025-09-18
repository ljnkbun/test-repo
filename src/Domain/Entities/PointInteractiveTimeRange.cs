using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointInteractiveTimeRange
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public int? Year { get; set; }

    public string? TimeRange { get; set; }

    public decimal? TotalCountInteraction { get; set; }

    public int? Month { get; set; }

    public DateTime? CalculateDate { get; set; }
}
