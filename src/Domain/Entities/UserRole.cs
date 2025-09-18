using System;
using System.Collections.Generic;

namespace Infra;

public partial class UserRole
{
    public long Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public int? TenantId { get; set; }

    public long UserId { get; set; }

    public int RoleId { get; set; }

    public virtual User User { get; set; } = null!;
}
