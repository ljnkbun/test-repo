using System;
using System.Collections.Generic;

namespace Infra;

public partial class GiftGiftMaster
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

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Price { get; set; }

    public string? Description { get; set; }

    public DateTime? EffectiveFrom { get; set; }

    public DateTime? EffectiveTo { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string? Status { get; set; }

    public string? ImageLink { get; set; }

    public string? NameUnsign { get; set; }

    public string? ProductType { get; set; }

    public string? Publisher { get; set; }
}
