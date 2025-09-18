using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerBeatPlanDetail
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

    public string? BeatPlanCode { get; set; }

    public string? OutletCode { get; set; }

    public string? Status { get; set; }

    public string? MasterNameUnSign { get; set; }

    public string? SalesmanCode { get; set; }

    public string? Frequency { get; set; }

    public int Priority { get; set; }
}
