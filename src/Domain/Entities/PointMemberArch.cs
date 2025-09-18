using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointMemberArch
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

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime? Birthday { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? RegionCode { get; set; }

    public string? MemberTypeCode { get; set; }

    public string? ChannelType { get; set; }

    public string? RankTypeCode { get; set; }

    public string? Address { get; set; }

    public string? Gender { get; set; }

    public string? Cards { get; set; }

    public bool IsActive { get; set; }

    public string? Status { get; set; }

    public string? FullRegionCode { get; set; }

    public string? FullMemberTypeCode { get; set; }

    public string? FullChannelTypeCode { get; set; }

    public string? IdCard { get; set; }

    public int? MemberLoyaltyInfoId { get; set; }

    public string? StandardMemberCode { get; set; }

    public string? AccountType { get; set; }

    public DateTime? JoiningDate { get; set; }

    public DateTime? WithdrawnDate { get; set; }

    public string? ReferenceInfo { get; set; }

    public string? Source { get; set; }

    public string? ExtraInfo { get; set; }

    public string? ReferralCode { get; set; }

    public string? ContractCode { get; set; }

    public string? Password { get; set; }
}
