using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointProduct
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

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? DeptCode { get; set; }

    public string? ClassCode { get; set; }

    public string? FullDeptCode { get; set; }

    public string? FullClassCode { get; set; }

    public bool IsActive { get; set; }

    public string? Source { get; set; }

    public string? BackupName { get; set; }

    public string? BackupDescription { get; set; }

    public virtual ICollection<PointProductSettingDetail> PointProductSettingDetails { get; set; } = new List<PointProductSettingDetail>();
}
