using System;
using System.Collections.Generic;

namespace Infra;

public partial class RewardsVoucherPattern
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

    public string? PatternCode { get; set; }

    public string? PatternName { get; set; }

    public string? Prefix { get; set; }

    public string? CharSet { get; set; }

    public string? LengthAutoGenString { get; set; }

    public string? Postfix { get; set; }

    public string? VoucherGroupCode { get; set; }

    public string? Notes { get; set; }

    public string? Status { get; set; }

    public string? PatternNameUnsign { get; set; }
}
