using System;
using System.Collections.Generic;

namespace Infra;

public partial class PaymentHistoryLog
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

    public int SaleId { get; set; }

    public string? Serial { get; set; }

    public string? SaleType { get; set; }

    public string? CreatorName { get; set; }

    public decimal SystemCoin { get; set; }

    public int PaymentStatus { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? PaymentNotes { get; set; }
}
