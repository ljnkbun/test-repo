using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointMemberLoyaltyInfo
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

    public string MemberCode { get; set; } = null!;

    public decimal Point { get; set; }

    public decimal Coin { get; set; }

    public int? TempRankId { get; set; }

    public int? RankId { get; set; }

    public DateTime RankValidTo { get; set; }

    public string? Source { get; set; }

    public decimal? ExpiringCoin { get; set; }

    public decimal? PointToNextTempRank { get; set; }

    public decimal? PointToKeepRank { get; set; }

    public int? LastRank { get; set; }

    public decimal? TempPoint { get; set; }

    public string? DepartmentLevel1 { get; set; }

    public string SaleType { get; set; } = null!;

    public int? RankTypeId { get; set; }

    public virtual ICollection<PointMember> PointMembers { get; set; } = new List<PointMember>();

    public virtual PointRank? Rank { get; set; }

    public virtual PointRank? TempRank { get; set; }
}
