using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointTargetAudienceDetail
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int? TenantId { get; set; }

    public string Code { get; set; } = null!;

    public int TargetAudienceId { get; set; }

    public string Type { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string Level { get; set; } = null!;

    public string FullValue { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? Source { get; set; }

    public virtual PointTargetAudience TargetAudience { get; set; } = null!;
}
