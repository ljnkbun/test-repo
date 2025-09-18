using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerOutletInfoArch
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

    public string? Lng { get; set; }

    public string? Lat { get; set; }

    public string? Email { get; set; }

    public string? Gender { get; set; }

    public long? Birthday { get; set; }

    public long? RegistrationDate { get; set; }

    public string? Pid { get; set; }

    public string? SourceId { get; set; }

    public bool ReceiveAds { get; set; }

    public string? RankCode { get; set; }

    public long? RankValidDate { get; set; }

    public decimal? CurrentPoint { get; set; }

    public string? NationalityCode { get; set; }

    public string? OccupationCode { get; set; }

    public string? Hobby { get; set; }

    public string? Address { get; set; }

    public string? Ward { get; set; }

    public string? District { get; set; }

    public string? Province { get; set; }

    public string? Country { get; set; }

    public string? Status { get; set; }

    public DateTime? LastActivityTime { get; set; }

    public DateTime? LastPurchaseTime { get; set; }

    public string? CommunicationLanguage { get; set; }

    public string? Notes { get; set; }

    public string? RankPropose { get; set; }

    public string? Pincode { get; set; }

    public string? NameUnSign { get; set; }

    public string? Avatar { get; set; }

    public bool WorkingPermit { get; set; }

    public string? CustomerCode { get; set; }

    public string? InterestOf { get; set; }

    public bool IsInterestCobrand { get; set; }

    public string? MemberCard { get; set; }

    public bool IsForeigner { get; set; }

    public bool IsSynced { get; set; }

    public string? ReferralCode { get; set; }

    public decimal? AccumulationPoint { get; set; }

    public string? OutletCode { get; set; }

    public string? ZaloName { get; set; }

    public string? DistributorCode { get; set; }

    public string? DistributorName { get; set; }

    public string? RegionCode { get; set; }

    public decimal? TargetRevenue { get; set; }

    public decimal? ActualRevenue { get; set; }

    public decimal? Bonus { get; set; }

    public decimal? MissingRevenue { get; set; }

    public long? RevenueUpdateDate { get; set; }

    public string? Note1 { get; set; }

    public string? Note2 { get; set; }

    public string? Note3 { get; set; }

    public string? Note4 { get; set; }

    public string? Note5 { get; set; }

    public string? SalesChannel { get; set; }

    public string? SupervisorCode { get; set; }

    public string? SupervisorName { get; set; }

    public DateTime? PhoneFirstDate { get; set; }

    public bool LockUpdatePhone { get; set; }

    public string? BrowserCode { get; set; }

    public string? DeviceNameCode { get; set; }

    public string? TypeOfDeviceCode { get; set; }

    public string? SalesmanCode { get; set; }

    public int? ConsumerId { get; set; }

    public bool LockUpdateChatId { get; set; }

    public decimal? CurrentCoin { get; set; }

    public decimal? PointToKeepRank { get; set; }

    public decimal? PointToNextRank { get; set; }

    public decimal? ExpiringCoin { get; set; }

    public DateTime? ExpiringCoinDate { get; set; }

    public bool LockUpdateProfile { get; set; }

    public string? CommunicationChannels { get; set; }

    public string? OutletType { get; set; }

    public string? Password { get; set; }

    public string? AccountCode { get; set; }

    public decimal AccumulationPointSellIn { get; set; }

    public decimal AccumulationPointSellOut { get; set; }

    public DateTime AnniversaryDate { get; set; }

    public string? BankAccountNumber { get; set; }

    public string? BossName { get; set; }

    public string? BusinessType { get; set; }

    public string? IdentificationCardBackImage { get; set; }

    public string? IdentificationCardFrontImage { get; set; }

    public string? IdentificationCardNumber { get; set; }

    public string? Sapcode { get; set; }

    public string? TaxCode { get; set; }

    public string? WarehouseAddress { get; set; }

    public string? BankAccountName { get; set; }

    public string? BankBranchName { get; set; }

    public string? BankName { get; set; }

    public string? BusinessCertification { get; set; }

    public int CounttoLock { get; set; }

    public bool IsLocked { get; set; }

    public DateTime? LockedDate { get; set; }

    public string? LockedType { get; set; }

    public DateTime? StarttimeCounttoLock { get; set; }

    public string? BusinessCertificationback { get; set; }

    public string? VerifyStatus { get; set; }

    public int EmployeeQuantity { get; set; }

    public double? StoreArea { get; set; }
}
