using System;
using System.Collections.Generic;

namespace Infra;

public partial class EntityChange
{
    public long Id { get; set; }

    public DateTime ChangeTime { get; set; }

    public byte ChangeType { get; set; }

    public long EntityChangeSetId { get; set; }

    public string? EntityId { get; set; }

    public string? EntityTypeFullName { get; set; }

    public int? TenantId { get; set; }

    public virtual EntityChangeSet EntityChangeSet { get; set; } = null!;

    public virtual ICollection<EntityPropertyChange> EntityPropertyChanges { get; set; } = new List<EntityPropertyChange>();
}
