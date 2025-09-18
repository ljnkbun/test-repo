using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerOutletInfoUpdateHistory
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

    public int OutletId { get; set; }

    public string? OutletCode { get; set; }

    public string? OldContent { get; set; }

    public string? NewContent { get; set; }

    public string? Type { get; set; }

    public string? TypeDescription { get; set; }
}
