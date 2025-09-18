using System;
using System.Collections.Generic;

namespace Infra;

public partial class PublishEventLog
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public bool IsDeleted { get; set; }

    public int TenantId { get; set; }

    public string? EventName { get; set; }

    public string? EventDataKey { get; set; }

    public string? Content { get; set; }

    public string? Status { get; set; }

    public string? Exceptions { get; set; }
}
