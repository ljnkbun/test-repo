using System;
using System.Collections.Generic;

namespace Infra;

public partial class RewardsGameInfor
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

    public string? CampaignId { get; set; }

    public string? CampaignName { get; set; }

    public string? Description { get; set; }

    public string? OutletCode { get; set; }

    public string? ZaloChatId { get; set; }

    public string? MemberCode { get; set; }

    public string? Phone { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Used { get; set; }

    public decimal? Remain { get; set; }

    public string? Link { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? PromotionMasterCode { get; set; }

    public string? PromotionCode { get; set; }

    public string? Status { get; set; }
}
