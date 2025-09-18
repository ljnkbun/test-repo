using System;
using System.Collections.Generic;

namespace Infra;

public partial class OrganizationUnit
{
    public long Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int? TenantId { get; set; }

    public long? ParentId { get; set; }

    public string Code { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public virtual ICollection<OrganizationUnit> InverseParent { get; set; } = new List<OrganizationUnit>();

    public virtual OrganizationUnit? Parent { get; set; }
}
