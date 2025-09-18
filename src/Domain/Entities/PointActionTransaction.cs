using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointActionTransaction
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

    public string? ActionCode { get; set; }

    public string? MemberCode { get; set; }

    public DateTime? TransactionTime { get; set; }

    public int? Value { get; set; }

    public string? ActionRuleSettingId { get; set; }

    public string? TransactionCode { get; set; }

    public string? Tags { get; set; }

    public string? ActionFilter { get; set; }

    public int? Set { get; set; }

    public int? MemberId { get; set; }

    public int? ActionId { get; set; }

    public long TransactionId { get; set; }

    public int? TransactionId1 { get; set; }

    public string? Source { get; set; }

    public virtual PointAction? Action { get; set; }

    public virtual PointMember? Member { get; set; }

    public virtual PointTransaction? TransactionId1Navigation { get; set; }
}
