using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointTransactionDetail
{
    public long Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int? TenantId { get; set; }

    public string TransactionCode { get; set; } = null!;

    public string ProductCode { get; set; } = null!;

    public string? ProductCategorySettingCode { get; set; }

    public string? ProductSettingCode { get; set; }

    public decimal Coin { get; set; }

    public decimal Point { get; set; }

    public string? DetailLineInfo { get; set; }

    public string? FullDeptCode { get; set; }

    public string? FullClassCode { get; set; }

    public decimal Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal AmountBeforeTax { get; set; }

    public decimal AmountIncludeTax { get; set; }

    public decimal CalcAmount { get; set; }

    public decimal TaxAmount { get; set; }

    public decimal ProductCategorySettingPointRatio { get; set; }

    public decimal ProductCategorySettingCoinRatio { get; set; }

    public decimal ProductSettingPoint { get; set; }

    public decimal ProductSettingCoin { get; set; }

    public string? Source { get; set; }
}
