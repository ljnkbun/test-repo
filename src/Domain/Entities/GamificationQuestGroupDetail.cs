using System;
using System.Collections.Generic;

namespace Infra;

public partial class GamificationQuestGroupDetail
{
    public int QuestGroupId { get; set; }

    public long QuestId { get; set; }

    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int TenantId { get; set; }

    public string? QuestGroupCode { get; set; }

    public string? QuestCode { get; set; }

    public int Ordinal { get; set; }

    public virtual GamificationQuest Quest { get; set; } = null!;

    public virtual GamificationQuestGroup QuestGroup { get; set; } = null!;
}
