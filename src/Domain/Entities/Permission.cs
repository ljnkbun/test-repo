using System;
using System.Collections.Generic;

namespace Infra;

public partial class Permission
{
    public long Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public int? TenantId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsGranted { get; set; }

    public string Discriminator { get; set; } = null!;

    public int? RoleId { get; set; }

    public long? UserId { get; set; }

    public virtual Role? Role { get; set; }

    public virtual User? User { get; set; }
}
