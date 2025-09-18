using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointVendorSetting
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

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Apilink { get; set; }

    public string? TokenKey { get; set; }

    public string? Status { get; set; }

    public string? VendorType { get; set; }

    public string? ApiVersion { get; set; }

    public string? ExtraData { get; set; }
}
