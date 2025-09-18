using System;
using System.Collections.Generic;

namespace Infra;

public partial class GamificationMission
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

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Avatar { get; set; }

    public string? LinkAvatar { get; set; }

    public int Ordinal { get; set; }

    public string? Status { get; set; }

    public decimal Coin { get; set; }

    public decimal Point { get; set; }

    public decimal Target { get; set; }

    public string? QuestCode { get; set; }

    public long QuestId { get; set; }

    public virtual GamificationQuest Quest { get; set; } = null!;
}
