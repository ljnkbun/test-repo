using System;
using System.Collections.Generic;

namespace Infra;

public partial class ConsumerdbSalesInvoiceDetail
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

    public int? SeqNo { get; set; }

    public string? MemberCode { get; set; }

    public string? DeptCode { get; set; }

    public string? DivCode { get; set; }

    public string? CategoryCode { get; set; }

    public string? ItemCode { get; set; }

    public string? BrandCode { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Sellingprice { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Amount { get; set; }

    public string? CustomerCode { get; set; }
}
