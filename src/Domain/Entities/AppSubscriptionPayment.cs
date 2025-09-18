using System;
using System.Collections.Generic;

namespace Infra;

public partial class AppSubscriptionPayment
{
    public long Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int Gateway { get; set; }

    public decimal Amount { get; set; }

    public int Status { get; set; }

    public int EditionId { get; set; }

    public int TenantId { get; set; }

    public int DayCount { get; set; }

    public int? PaymentPeriodType { get; set; }

    public string? PaymentId { get; set; }

    public string? InvoiceNo { get; set; }

    public virtual Edition Edition { get; set; } = null!;
}
