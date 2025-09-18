using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointEventSubscriptionHeader
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

    public bool IsActive { get; set; }

    public string SecretKey { get; set; } = null!;

    public string? Url { get; set; }

    public string? Description { get; set; }

    public int? SettingParamId { get; set; }

    public virtual PointTargetAudience? SettingParam { get; set; }
}
