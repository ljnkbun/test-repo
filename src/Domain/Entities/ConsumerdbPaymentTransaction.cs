using System;
using System.Collections.Generic;

namespace Infra;

public partial class ConsumerdbPaymentTransaction
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public int TenantId { get; set; }

    public string? SalesInvoiceCode { get; set; }

    public string? PaymentMethod { get; set; }

    public decimal? Amount { get; set; }
}
