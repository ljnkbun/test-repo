using System;
using System.Collections.Generic;

namespace Infra;

public partial class RewardsReferralTransaction
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

    public string? TransactionCode { get; set; }

    public string? ReferralUser { get; set; }

    public string? ReferalCode { get; set; }

    public DateTime? ReferalTime { get; set; }

    public string? VoucherGroupCode { get; set; }

    public bool IsGranted { get; set; }
}
