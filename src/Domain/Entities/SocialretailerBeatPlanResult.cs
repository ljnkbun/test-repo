using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerBeatPlanResult
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

    public string BeatPlanCode { get; set; } = null!;

    public string BeatPlanName { get; set; } = null!;

    public string SalemanCode { get; set; } = null!;

    public string OutletCode { get; set; } = null!;

    public string? CheckInLongitude { get; set; }

    public string? CheckInLastitude { get; set; }

    public string? CheckInDistant { get; set; }

    public string CheckInImageLink { get; set; } = null!;

    public DateTime CheckInTime { get; set; }

    public string? CheckOutLongitude { get; set; }

    public string? CheckOutLastitude { get; set; }

    public string? CheckOutDistant { get; set; }

    public string CheckOutImageLink { get; set; } = null!;

    public DateTime CheckOutTime { get; set; }

    public Guid CheckListResultId { get; set; }

    public float Rate { get; set; }

    public int BeatPlanDetailId { get; set; }

    public int TaskResultId { get; set; }
}
