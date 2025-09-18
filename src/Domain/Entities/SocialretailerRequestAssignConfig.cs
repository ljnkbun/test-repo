using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerRequestAssignConfig
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

    public string RequestType { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int Step { get; set; }

    public int RoleId { get; set; }

    public string? Assigner { get; set; }

    public string? CreatorName { get; set; }

    public string? LastModifierName { get; set; }

    public string? Type { get; set; }
}
