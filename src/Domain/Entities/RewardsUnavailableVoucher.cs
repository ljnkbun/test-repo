using System;
using System.Collections.Generic;

namespace Infra;

public partial class RewardsUnavailableVoucher
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

    public string? RedemptionUser { get; set; }

    public string? VoucherGroupCode { get; set; }

    public int? TerminalId { get; set; }

    public DateTime? TerminalTime { get; set; }

    public DateTime? RedemptionTime { get; set; }

    public DateTime? IssuedTime { get; set; }

    public string? Status { get; set; }

    public string? TriggerEvent { get; set; }

    public string? EventFilter { get; set; }

    public string? ReferenceCode { get; set; }

    public int? MaxSlipPrint { get; set; }

    public int? CurrentSlipPrint { get; set; }

    public string? VoucherUser { get; set; }
}
