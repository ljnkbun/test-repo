using System;
using System.Collections.Generic;

namespace Infra;

public partial class NotificationTemplate
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

    public string? TemplateName { get; set; }

    public string? Type { get; set; }

    public string? Sender { get; set; }

    public string? ChannelCode { get; set; }

    public string? ContentVn { get; set; }

    public string? ContentEn { get; set; }

    public string? TitleVn { get; set; }

    public string? TitleEn { get; set; }

    public string? Actions { get; set; }

    public string? Items { get; set; }

    public string? Status { get; set; }

    public string? TemplateNameUnSign { get; set; }
}
