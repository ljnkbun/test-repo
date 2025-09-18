using System;
using System.Collections.Generic;

namespace Infra;

public partial class AppBinaryObject
{
    public Guid Id { get; set; }

    public int? TenantId { get; set; }

    public byte[] Bytes { get; set; } = null!;
}
