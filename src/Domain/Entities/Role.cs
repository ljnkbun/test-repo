using System;
using System.Collections.Generic;

namespace Infra;

public partial class Role
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

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public bool IsStatic { get; set; }

    public bool IsDefault { get; set; }

    public string NormalizedName { get; set; } = null!;

    public string? ConcurrencyStamp { get; set; }

    public string? OrganazationUnitDefault { get; set; }

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();

    public virtual ICollection<RoleClaim> RoleClaims { get; set; } = new List<RoleClaim>();
}
