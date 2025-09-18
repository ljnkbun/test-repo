using System;
using System.Collections.Generic;

namespace Infra;

public partial class ConsumerdbTargetAudienceHeader
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

    public string? TargetAudienceName { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public bool ApplyForMembership { get; set; }

    public bool SelectTop { get; set; }

    public string? ConditionTopsorting { get; set; }

    public decimal? QuantityTopgroup { get; set; }

    public string? TargetAudienceNameUnsign { get; set; }

    public bool IsFixedList { get; set; }

    public decimal? NumberOfMember { get; set; }

    public decimal? ScheduleTime { get; set; }

    public DateTime? LastRunTime { get; set; }

    public DateTime? NextRunTime { get; set; }

    public string? RunStatus { get; set; }
}
