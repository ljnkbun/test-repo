using System;
using System.Collections.Generic;

namespace Infra;

public partial class WebHookNotificationInfo
{
    public Guid Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public string EventName { get; set; } = null!;

    public string? Data { get; set; }

    public string? DataTypeName { get; set; }

    public string? WebHookUri { get; set; }

    public long WebHookSubscriptionInfoId { get; set; }
}
