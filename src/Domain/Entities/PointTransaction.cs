using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointTransaction
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

    public decimal? ActionRuleCoin { get; set; }

    public decimal? ActionRulePoint { get; set; }

    public string? ActionRuleSettingCode { get; set; }

    public string? Approver { get; set; }

    public decimal BaseCoinRatio { get; set; }

    public decimal BasePointRatio { get; set; }

    public string? BaseSettingCode { get; set; }

    public DateTime BusinessTime { get; set; }

    public string Code { get; set; } = null!;

    public decimal Coin { get; set; }

    public string? Description { get; set; }

    public string? DistributorCode { get; set; }

    public decimal EventCoinRatio { get; set; }

    public decimal EventPointRatio { get; set; }

    public string? EventSettingCode { get; set; }

    public string? FullChannelTypeCode { get; set; }

    public string? FullMemberTypeCode { get; set; }

    public string? FullRegionCode { get; set; }

    public string? FullSalesRegionCode { get; set; }

    public string MemberCode { get; set; } = null!;

    public string? OriginalOrders { get; set; }

    public DateTime OriginalOrdersTime { get; set; }

    public decimal PlusCoin { get; set; }

    public decimal PlusPoint { get; set; }

    public decimal Point { get; set; }

    public string? RankCode { get; set; }

    public decimal RankCoinRatio { get; set; }

    public decimal RankPointRatio { get; set; }

    public string? RankSettingCode { get; set; }

    public string? RankTypeCode { get; set; }

    public decimal RatioCoin { get; set; }

    public decimal RatioPoint { get; set; }

    public string Reason { get; set; } = null!;

    public string? ReferralSettingCode { get; set; }

    public DateTime RequestDate { get; set; }

    public string? SenioritySettingCode { get; set; }

    public string? Source { get; set; }

    public string? SpecialSettingCode { get; set; }

    public string? StandardMemberCode { get; set; }

    public string? TerminalNo { get; set; }

    public decimal? TotalAmountBeforeTax { get; set; }

    public decimal? TotalAmountIncludeTax { get; set; }

    public decimal? TotalCalcAmount { get; set; }

    public int? TotalDetailLine { get; set; }

    public decimal? TotalTaxAmount { get; set; }

    public decimal? UsedCoin { get; set; }

    public decimal? TotalAmountIssuePoint { get; set; }

    public decimal? TotalAmountIssueCoin { get; set; }

    public virtual ICollection<PointActionTransaction> PointActionTransactions { get; set; } = new List<PointActionTransaction>();
}
