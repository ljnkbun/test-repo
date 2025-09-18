using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointProductSettingDetail
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

    public int ProductSettingId { get; set; }

    public int? ProductId { get; set; }

    public int Value { get; set; }

    public decimal PointValue { get; set; }

    public decimal CoinValue { get; set; }

    public decimal MaxSet { get; set; }

    public bool IsActive { get; set; }

    public DateTime EffectiveFrom { get; set; }

    public DateTime EffectiveTo { get; set; }

    public string? Source { get; set; }

    public string? DepartmentCode { get; set; }

    public string? DetailType { get; set; }

    public virtual ICollection<PointProductSettingDetailByRank> PointProductSettingDetailByRanks { get; set; } = new List<PointProductSettingDetailByRank>();

    public virtual PointProduct? Product { get; set; }

    public virtual PointProductSetting ProductSetting { get; set; } = null!;
}
