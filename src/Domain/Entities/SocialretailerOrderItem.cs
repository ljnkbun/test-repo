using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerOrderItem
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

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public decimal Quantity { get; set; }

    public decimal Price { get; set; }

    public string? DiscountNote { get; set; }

    public string? Description { get; set; }

    public string? ItemCode { get; set; }

    public string? ProductName { get; set; }
}
