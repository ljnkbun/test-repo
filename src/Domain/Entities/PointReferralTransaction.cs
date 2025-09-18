using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointReferralTransaction
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int? TenantId { get; set; }

    public string? Code { get; set; }

    public string? ReferralSettingCode { get; set; }

    public string? MemberCode { get; set; }

    public string? RefMemberCode { get; set; }

    public string? Type { get; set; }

    public decimal TempCoin { get; set; }

    public decimal TempPoint { get; set; }

    public DateTime ReferralDate { get; set; }

    public DateTime ReferralExpiredDate { get; set; }

    public bool IsAvailable { get; set; }

    public int? CampaignId { get; set; }

    public string? Source { get; set; }

    public virtual PointCampaign? Campaign { get; set; }
}
