using System;
using System.Collections.Generic;

namespace Infra;

public partial class NotificationLog
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public int TenantId { get; set; }

    public string? TriggerBy { get; set; }

    public string? Sender { get; set; }

    public string? Receiver { get; set; }

    public string? ChannelCode { get; set; }

    public string? ReferenceCode { get; set; }

    public string? Type { get; set; }

    public string? Content { get; set; }

    public string? Title { get; set; }

    public string? Actions { get; set; }

    public string? Items { get; set; }

    public string? Status { get; set; }

    public string? Message { get; set; }

    public string? TriggerName { get; set; }

    public string? ChannelMemberId { get; set; }

    public string? ChannelTransactionId { get; set; }
}
