using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointEventSubscriptionDetail
{
    public int Id { get; set; }

    public int? TenantId { get; set; }

    public string? EventTemplateId { get; set; }

    public string? EventTemplateGroup { get; set; }
}
