using System;
using System.Collections.Generic;

namespace Infra;

public partial class GamificationGameInfo
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

    public string? GameCode { get; set; }

    public string? GameNameEn { get; set; }

    public string? GameNameVn { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Status { get; set; }

    public string? GameType { get; set; }

    public string? TargetAudienceType { get; set; }

    public int? TargetAudienceId { get; set; }

    public string? Event { get; set; }

    public string? ActionFilter { get; set; }

    public string? Description { get; set; }

    public string? BackgroundImage { get; set; }

    public string? GameRuleImage { get; set; }

    public decimal? MaxRewardPerPlayer { get; set; }

    public string? DescriptionOutOfReward { get; set; }

    public decimal? TimeToExpiredTicket { get; set; }
}
