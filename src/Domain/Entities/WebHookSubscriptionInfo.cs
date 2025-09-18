using System;
using System.Collections.Generic;

namespace Infra;

public partial class WebHookSubscriptionInfo
{
    public long Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public string? Description { get; set; }

    public string WebHookUri { get; set; } = null!;

    public string? Secret { get; set; }

    public string? Event { get; set; }

    public string? EventFilter { get; set; }

    public string? HttpHeader { get; set; }

    public string? Data { get; set; }

    public long UserId { get; set; }

    public Guid EventSubscriptionId { get; set; }

    public int? TenantId { get; set; }

    public string? Source { get; set; }
}
