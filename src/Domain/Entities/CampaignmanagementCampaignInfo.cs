using System;
using System.Collections.Generic;

namespace Infra;

public partial class CampaignmanagementCampaignInfo
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

    public string? CampaignName { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public string? Address { get; set; }

    public string? Lng { get; set; }

    public string? Lat { get; set; }

    public string? CampaignType { get; set; }

    public decimal? Budget { get; set; }

    public decimal? NumberOfLead { get; set; }

    public string? CampaignCode { get; set; }

    public string? CampaignNameUnSign { get; set; }
}
