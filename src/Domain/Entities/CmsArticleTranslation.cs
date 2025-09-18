using System;
using System.Collections.Generic;

namespace Infra;

public partial class CmsArticleTranslation
{
    public int Id { get; set; }

    public int? TenantId { get; set; }

    public string? Description { get; set; }

    public string? Content { get; set; }

    public string? Name { get; set; }

    public int CoreId { get; set; }

    public string? Language { get; set; }

    public string? NameUnSign { get; set; }
}
