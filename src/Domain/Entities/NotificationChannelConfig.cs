using System;
using System.Collections.Generic;

namespace Infra;

public partial class NotificationChannelConfig
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int TenantId { get; set; }

    public string? ChannelCode { get; set; }

    public string? ChannelType { get; set; }

    public string? ChannelConfigurations { get; set; }

    public string? Status { get; set; }

    public int? ChannelId { get; set; }

    public virtual NotificationChannel? Channel { get; set; }
}
