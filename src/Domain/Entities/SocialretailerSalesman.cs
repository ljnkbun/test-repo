using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerSalesman
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

    public string? SalesmanCode { get; set; }

    public string? SalesmanName { get; set; }

    public string? Password { get; set; }

    public string? Status { get; set; }

    public string? MasterNameUnSign { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public int? ConsumerId { get; set; }

    public string? MemberCode { get; set; }

    public int? ManagerId { get; set; }

    public string? RegionCode { get; set; }
}
