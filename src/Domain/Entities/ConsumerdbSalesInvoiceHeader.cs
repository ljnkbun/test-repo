using System;
using System.Collections.Generic;

namespace Infra;

public partial class ConsumerdbSalesInvoiceHeader
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public int TenantId { get; set; }

    public DateTime? PostingDate { get; set; }

    public string? SalesInvoiceCode { get; set; }

    public string? TerminalNo { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? MemberCode { get; set; }

    public decimal? Point { get; set; }

    public string? TransactionType { get; set; }

    public string? Location { get; set; }

    public decimal? Allowance { get; set; }

    public string? CustomerCode { get; set; }

    public string? ReferenceCode { get; set; }
}
