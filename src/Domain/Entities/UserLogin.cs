using System;
using System.Collections.Generic;

namespace Infra;

public partial class UserLogin
{
    public long Id { get; set; }

    public int? TenantId { get; set; }

    public long UserId { get; set; }

    public string LoginProvider { get; set; } = null!;

    public string ProviderKey { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
