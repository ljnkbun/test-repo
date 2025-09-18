using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerSapserial
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

    public int ProductId { get; set; }

    public string Serial { get; set; } = null!;

    public int Year { get; set; }

    public int Source { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime DateSellIn { get; set; }

    public DateTime DateSellOut { get; set; }

    public string IsSellInStatus { get; set; } = null!;

    public string IsSellOutStatus { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public int Month { get; set; }

    public string? Description { get; set; }

    public bool IsMt { get; set; }

    public string? RegionLevel1 { get; set; }

    public string? SerialType { get; set; }

    public int Quantity { get; set; }

    public string? ReturnType { get; set; }

    public string? ReasonDelete { get; set; }

    public string? SystemDescription { get; set; }

    public int? Classify { get; set; }

    public string? WarrantyCode { get; set; }

    public DateTime DateSellDis { get; set; }

    public DateTime DateSellVipShop { get; set; }

    public bool IsDisSellThru { get; set; }

    public bool IsVssellThru { get; set; }
}
