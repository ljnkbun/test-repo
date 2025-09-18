using System;
using System.Collections.Generic;

namespace Infra;

public partial class Feature
{
    public long Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public int? TenantId { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string Discriminator { get; set; } = null!;

    public int? EditionId { get; set; }

    public virtual Edition? Edition { get; set; }
}
