using System;
using System.Collections.Generic;

namespace Infra;

public partial class CommunicationCommunication
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

    public string? Channel { get; set; }

    public string? LanguageDefault { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public int? CommunicationTargetAudienceId { get; set; }

    public string? Cron { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Description { get; set; }

    public string? MessageType { get; set; }

    public string? MessageAction { get; set; }

    public string? ContentType { get; set; }

    public string? ContentVn { get; set; }

    public string? ContentEn { get; set; }

    public string? SubjectVn { get; set; }

    public string? SubjectEn { get; set; }

    public string? ImageUrl { get; set; }

    public string? ExtraUrl { get; set; }

    public string? NameUnsign { get; set; }

    public string? ExtraParam { get; set; }

    public string? TargetAudienceType { get; set; }

    public bool ImmediatelyOnEvent { get; set; }

    public string? EventType { get; set; }

    public string? BroadcastCategory { get; set; }

    public string? Actions { get; set; }

    public string? TargetScreen { get; set; }

    public virtual ICollection<EmailTemplate> EmailTemplates { get; set; } = new List<EmailTemplate>();
}
