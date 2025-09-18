using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerMemberWareHouse
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

    public string? Name { get; set; }

    public string? Lng { get; set; }

    public string? Lat { get; set; }

    public string? Address { get; set; }

    public string? Ward { get; set; }

    public string? District { get; set; }

    public string? Province { get; set; }

    public string? Status { get; set; }

    public string? VerifyStatus { get; set; }

    public string? Image { get; set; }
}
