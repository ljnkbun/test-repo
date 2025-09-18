using System;
using System.Collections.Generic;

namespace Infra;

public partial class NotificationChannel
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public string ChannelCode { get; set; } = null!;

    public string? ChannelDescription { get; set; }

    public string? ChannelType { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<NotificationChannelConfig> NotificationChannelConfigs { get; set; } = new List<NotificationChannelConfig>();
}
