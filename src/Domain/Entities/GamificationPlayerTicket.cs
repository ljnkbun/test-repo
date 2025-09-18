using System;
using System.Collections.Generic;

namespace Infra;

public partial class GamificationPlayerTicket
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

    public string? PlayerCode { get; set; }

    public string? GameCode { get; set; }

    public string? Status { get; set; }

    public DateTime? UsedDate { get; set; }

    public DateTime? ExpiredDateTime { get; set; }
}
