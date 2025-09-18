using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointProductCategorySettingDetail
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int? TenantId { get; set; }

    public string Code { get; set; } = null!;

    public int ProductCategorySettingId { get; set; }

    public int Type { get; set; }

    public bool IsActive { get; set; }

    public string Value { get; set; } = null!;

    public string FullValue { get; set; } = null!;

    public string? Source { get; set; }

    public virtual PointProductCategorySetting ProductCategorySetting { get; set; } = null!;
}
