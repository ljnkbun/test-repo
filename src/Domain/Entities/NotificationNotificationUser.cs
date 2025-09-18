using System;
using System.Collections.Generic;

namespace Infra;

public partial class NotificationNotificationUser
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

    public string? MemberCode { get; set; }

    public string? MemberName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Status { get; set; }

    public string? CommunicationLanguage { get; set; }

    public string? MemberNameUnsign { get; set; }

    public string? CommunicationChannels { get; set; }
}
