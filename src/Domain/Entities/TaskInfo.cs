using System;
using System.Collections.Generic;

namespace Infra;

public partial class TaskInfo
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

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public int? TargetAudienceId { get; set; }

    public string? Status { get; set; }

    public DateTime? EffectiveFrom { get; set; }

    public DateTime? EffectiveTo { get; set; }

    public string? TargetAudienceType { get; set; }

    public string? Channel { get; set; }

    public string? Cron { get; set; }

    public string? DescriptionEn { get; set; }

    public string? DescriptionVn { get; set; }

    public string? ImageLink { get; set; }

    public bool IsImmediately { get; set; }

    public string? OccurType { get; set; }

    public DateTime? PublishTime { get; set; }
}
