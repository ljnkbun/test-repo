using System;
using System.Collections.Generic;

namespace Infra;

public partial class Setting
{
    public long Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public int? TenantId { get; set; }

    public long? UserId { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    public virtual User? User { get; set; }
}
