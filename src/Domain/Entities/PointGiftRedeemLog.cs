using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointGiftRedeemLog
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public int? TenantId { get; set; }

    public string? MemberCode { get; set; }

    public string? GiftCode { get; set; }

    public string? TransactionCode { get; set; }

    public string? ReferenceCode { get; set; }

    public string? Type { get; set; }

    public string? Data { get; set; }

    public string? Status { get; set; }
}
