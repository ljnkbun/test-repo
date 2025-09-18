using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerSaleOrderDetail
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

    public Guid OrderDetailGuid { get; set; }

    public string? ProductCode { get; set; }

    public int Quantity { get; set; }

    public float Discount { get; set; }

    public float Price { get; set; }

    public float Vat { get; set; }

    public float LineTotal { get; set; }

    public string? DiscountDesc { get; set; }

    public string? Desc { get; set; }

    public Guid OrderGuid { get; set; }
}
