using System;
using System.Collections.Generic;

namespace Infra;

public partial class GamificationTransferTransaction
{
    public long Id { get; set; }

    public string? FromMemberCode { get; set; }

    public string? ToMemberCode { get; set; }

    public DateTime Date { get; set; }

    public decimal Value { get; set; }

    public int TenantId { get; set; }

    public DateTime CreationTime { get; set; }
}
