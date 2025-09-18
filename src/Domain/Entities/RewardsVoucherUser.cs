using System;
using System.Collections.Generic;

namespace Infra;

public partial class RewardsVoucherUser
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public int TenantId { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? ZaloChatId { get; set; }

    public string? Email { get; set; }

    public string? FacebookId { get; set; }

    public string? MemberCode { get; set; }

    public string? CommunicationLanguage { get; set; }

    public string? CommunicationChannels { get; set; }

    public int? TargetAudienceLinkId { get; set; }

    public int? RewardTargetAudienceId { get; set; }

    public virtual RewardsRewardTargetAudience? RewardTargetAudience { get; set; }
}
