using System;
using System.Collections.Generic;

namespace Infra;

public partial class UserNotification
{
    public Guid Id { get; set; }

    public int? TenantId { get; set; }

    public long UserId { get; set; }

    public Guid TenantNotificationId { get; set; }

    public int State { get; set; }

    public DateTime CreationTime { get; set; }
}
