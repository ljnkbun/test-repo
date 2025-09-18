using System;
using System.Collections.Generic;

namespace Infra;

public partial class GamificationQuestGroup
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

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public int Ordinal { get; set; }

    public string? Status { get; set; }

    public int Type { get; set; }

    public virtual ICollection<GamificationQuestGroupDetail> GamificationQuestGroupDetails { get; set; } = new List<GamificationQuestGroupDetail>();
}
