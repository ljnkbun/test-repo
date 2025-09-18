using System;
using System.Collections.Generic;

namespace Infra;

public partial class PromoRewardRedemptionRequest
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

    public int CampaignId { get; set; }

    public string? MemberCode { get; set; }

    public string? Status { get; set; }

    public DateTime? RequestDate { get; set; }

    public int? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? Note { get; set; }

    public decimal TotalPoint { get; set; }
}
