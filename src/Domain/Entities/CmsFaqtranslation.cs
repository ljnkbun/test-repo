using System;
using System.Collections.Generic;

namespace Infra;

public partial class CmsFaqtranslation
{
    public int Id { get; set; }

    public int? TenantId { get; set; }

    public string? Question { get; set; }

    public string? Answer { get; set; }

    public int CoreId { get; set; }

    public string? Language { get; set; }

    public virtual CmsFaq Core { get; set; } = null!;
}
