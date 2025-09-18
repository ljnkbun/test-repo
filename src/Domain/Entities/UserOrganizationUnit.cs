using System;
using System.Collections.Generic;

namespace Infra;

public partial class UserOrganizationUnit
{
    public long Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public int? TenantId { get; set; }

    public long UserId { get; set; }

    public long OrganizationUnitId { get; set; }

    public bool IsDeleted { get; set; }
}
