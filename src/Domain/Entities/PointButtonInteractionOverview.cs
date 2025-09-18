using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointButtonInteractionOverview
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public int? Year { get; set; }

    public string? ButtonEvent { get; set; }

    public decimal? TotalCountInteraction { get; set; }

    public DateTime? CalculateDate { get; set; }

    public int? Month { get; set; }
}
