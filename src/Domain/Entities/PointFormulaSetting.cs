using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointFormulaSetting
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int? TenantId { get; set; }

    public string Code { get; set; } = null!;

    public decimal DefaultBasePoint { get; set; }

    public decimal DefaultBaseCoin { get; set; }

    public decimal DefaultEventPoint { get; set; }

    public decimal DefaultEventCoin { get; set; }

    public decimal DefaultProductCategoryPoint { get; set; }

    public decimal DefaultProductCategoryCoin { get; set; }

    public decimal DefaultSpecialPoint { get; set; }

    public decimal DefaultSpecialCoin { get; set; }

    public decimal DefaultProductPoint { get; set; }

    public decimal DefaultProductCoin { get; set; }

    public decimal DefaultRankPoint { get; set; }

    public decimal DefaultRankCoin { get; set; }

    public string? Fomula { get; set; }

    public bool IsActive { get; set; }

    public decimal DefaultReturnBasePoint { get; set; }

    public decimal DefaultReturnBaseCoin { get; set; }

    public string? Source { get; set; }
}
