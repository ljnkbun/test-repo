using System;
using System.Collections.Generic;

namespace Infra;

public partial class RewardsVoucherTransaction
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

    public string? VoucherCode { get; set; }

    public string? VoucherUser { get; set; }

    public string? VoucherGroupCode { get; set; }

    public string? PatternCode { get; set; }

    public string? PublisherCode { get; set; }

    public DateTime? IssuedTime { get; set; }

    public DateTime? RedemptionStartTime { get; set; }

    public DateTime? RedemptionEndTime { get; set; }

    public string? Notes { get; set; }

    public string? Status { get; set; }

    public string? ReferenceCode { get; set; }

    public int? MaxPaperPrint { get; set; }

    public int? CurrentPaperPrint { get; set; }

    public string? TriggerEvent { get; set; }

    public string? EventFilter { get; set; }
}
