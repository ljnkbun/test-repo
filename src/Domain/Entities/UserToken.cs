using System;
using System.Collections.Generic;

namespace Infra;

public partial class UserToken
{
    public long Id { get; set; }

    public int? TenantId { get; set; }

    public long UserId { get; set; }

    public string? LoginProvider { get; set; }

    public string? Name { get; set; }

    public string? Value { get; set; }

    public DateTime? ExpireDate { get; set; }

    public virtual User User { get; set; } = null!;
}
