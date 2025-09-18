using System;
using System.Collections.Generic;

namespace Infra;

public partial class ConsumerdbTargetAudienceDetail
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

    public string? ConditionType { get; set; }

    public string? ConditionName { get; set; }

    public string? Operator { get; set; }

    public string? ValueFrom { get; set; }

    public string? ValueTo { get; set; }

    public decimal? ValueFromNumber { get; set; }

    public decimal? ValueToNumber { get; set; }

    public DateTime? ValueFromDate { get; set; }

    public DateTime? ValueToDate { get; set; }

    public int? TargetAudienceId { get; set; }
}
