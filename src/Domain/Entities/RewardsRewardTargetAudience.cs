using System;
using System.Collections.Generic;

namespace Infra;

public partial class RewardsRewardTargetAudience
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

    public string? TargetAudienceName { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public int? TargetAudienceLinkId { get; set; }

    public virtual ICollection<RewardsVoucherUser> RewardsVoucherUsers { get; set; } = new List<RewardsVoucherUser>();
}
