using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointCampaignPerformanceOverview
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public string? CampaignName { get; set; }

    public decimal? NumberOfSent { get; set; }

    public decimal? NumberOfReceived { get; set; }

    public decimal? NumberOfSeen { get; set; }

    public decimal? NumberOfFail { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public int? CampaignId { get; set; }

    public DateTime? CalculateDate { get; set; }
}
