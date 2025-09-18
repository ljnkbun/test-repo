using System;
using System.Collections.Generic;

namespace Infra;

public partial class NotificationAppPushTransaction
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public int TenantId { get; set; }

    public string? Sender { get; set; }

    public string? Receiver { get; set; }

    public string? ReferenceCode { get; set; }

    public string? Content { get; set; }

    public string? Title { get; set; }

    public string? Status { get; set; }

    public string? Data { get; set; }
}
