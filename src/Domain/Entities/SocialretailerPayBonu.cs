using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerPayBonu
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public int TenantId { get; set; }

    public string? OutletCode { get; set; }

    public decimal? Revenue { get; set; }

    public string? Type { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public DateTime? CalculatedDate { get; set; }

    public decimal? BonusPoint { get; set; }

    public decimal? BonusCoin { get; set; }

    public string? Status { get; set; }

    public decimal? BonusAmount { get; set; }
}
