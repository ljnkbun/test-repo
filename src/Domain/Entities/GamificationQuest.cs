using System;
using System.Collections.Generic;

namespace Infra;

public partial class GamificationQuest
{
    public long Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int? TenantId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Avatar { get; set; }

    public string? LinkAvatar { get; set; }

    public string Status { get; set; } = null!;

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public string? Rewarding { get; set; }

    public string? Tag { get; set; }

    public virtual ICollection<GamificationMission> GamificationMissions { get; set; } = new List<GamificationMission>();

    public virtual ICollection<GamificationQuestGroupDetail> GamificationQuestGroupDetails { get; set; } = new List<GamificationQuestGroupDetail>();
}
