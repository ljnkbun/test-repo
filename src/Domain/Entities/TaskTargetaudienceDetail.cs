using System;
using System.Collections.Generic;

namespace Infra;

public partial class TaskTargetaudienceDetail
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

    public int? TaskTargetAudienceId { get; set; }

    public string? MemberCode { get; set; }

    public string? Name { get; set; }

    public string? CommunicationChannel { get; set; }

    public string? ZaloChatId { get; set; }

    public string? Email { get; set; }

    public string? CommunicationLanguage { get; set; }

    public string? FacebookId { get; set; }

    public string? OutletCode { get; set; }

    public string? Phone { get; set; }
}
