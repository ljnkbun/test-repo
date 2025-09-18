using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialshopperShopperInfo
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

    public string? MemberCode { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Gender { get; set; }

    public long? Birthday { get; set; }

    public long? RegistrationDate { get; set; }

    public string? Pid { get; set; }

    public bool ReceiveAds { get; set; }

    public string? RankCode { get; set; }

    public long? RankValidDate { get; set; }

    public decimal? CurrentPoint { get; set; }

    public string? NationalityCode { get; set; }

    public string? Address { get; set; }

    public string? Ward { get; set; }

    public string? District { get; set; }

    public string? Province { get; set; }

    public string? Country { get; set; }

    public string? Status { get; set; }

    public string? CommunicationLanguage { get; set; }

    public string? Notes { get; set; }

    public string? RankPropose { get; set; }

    public string? Pincode { get; set; }

    public string? NameUnSign { get; set; }

    public string? Avatar { get; set; }

    public string? MemberCard { get; set; }

    public string? CommunicationChannels { get; set; }
}
