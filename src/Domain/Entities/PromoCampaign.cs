using System;
using System.Collections.Generic;

namespace Infra;

public partial class PromoCampaign
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

    public string? Code { get; set; }

    public string? Name { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Description { get; set; }

    public string? MemberSegment { get; set; }

    public string? Banner { get; set; }

    public bool IsActive { get; set; }

    public DateTime? RedemptionFrom { get; set; }

    public DateTime? RedemptionTo { get; set; }

    public string? TermsCondition { get; set; }

    public bool AllowChangeReward { get; set; }
}
