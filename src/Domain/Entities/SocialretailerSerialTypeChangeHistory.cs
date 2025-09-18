using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerSerialTypeChangeHistory
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

    public string? Serial { get; set; }

    public string? SerialType { get; set; }

    public string? DocNum { get; set; }

    public string? ReferFrom { get; set; }

    public string? ProductCode { get; set; }

    public string? Reason { get; set; }

    public bool SyncStatus { get; set; }

    public string? CreatorName { get; set; }

    public string? Plant { get; set; }
}
