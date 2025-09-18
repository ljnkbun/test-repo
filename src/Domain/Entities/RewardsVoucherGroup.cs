using System;
using System.Collections.Generic;

namespace Infra;

public partial class RewardsVoucherGroup
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

    public string? VoucherGroupCode { get; set; }

    public string? VoucherGroupName { get; set; }

    public string? PublisherCode { get; set; }

    public decimal? PointPrice { get; set; }

    public decimal? CurrencyPrice { get; set; }

    public string? ApplyFor { get; set; }

    public string? TitleVn { get; set; }

    public string? TitleEn { get; set; }

    public string? DescriptionVn { get; set; }

    public string? DescriptionEn { get; set; }

    public string? ImageLink { get; set; }

    public string? Template { get; set; }

    public DateTime? GrantStartTime { get; set; }

    public DateTime? GrantEndTime { get; set; }

    public string? BillCalculationType { get; set; }

    public decimal? BillTotal { get; set; }

    public string? GrantApplyType { get; set; }

    public string? GrantAppliedLocation { get; set; }

    public string? GrantAppliedStore { get; set; }

    public string? GrantAppliedProdLv1 { get; set; }

    public string? GrantAppliedProdLv2 { get; set; }

    public string? GrantAppliedProdLv3 { get; set; }

    public string? GrantAppliedProdLv4 { get; set; }

    public string? GrantAppliedProdLv5 { get; set; }

    public string? GrantAppliedProduct { get; set; }

    public string? RedemptionApplyType { get; set; }

    public string? RedemptionApplyLocation { get; set; }

    public string? RedemptionApplyStore { get; set; }

    public string? RedemptionAppliedProdLv1 { get; set; }

    public string? RedemptionAppliedProdLv2 { get; set; }

    public string? RedemptionAppliedProdLv3 { get; set; }

    public string? RedemptionAppliedProdLv4 { get; set; }

    public string? RedemptionAppliedProdLv5 { get; set; }

    public string? RedemptionAppliedProduct { get; set; }

    public DateTime? RedemptionStartTime { get; set; }

    public DateTime? RedemptionEndTime { get; set; }

    public string? RedemptionType { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? DiscountRate { get; set; }

    public string? GiftCode { get; set; }

    public decimal? MinPurchaseAmount { get; set; }

    public decimal? MaxDiscountAmount { get; set; }

    public decimal? QtyGrantPerPerson { get; set; }

    public string? AcceptedEvent { get; set; }

    public string? GrantMsgTemplateType { get; set; }

    public string? GrantMsgTemplateId { get; set; }

    public string? GrantMsgTemplateContentVn { get; set; }

    public string? GrantMsgTemplateContentEn { get; set; }

    public string? RedemptionMsgTemplateType { get; set; }

    public string? RedemptionMsgTemplateId { get; set; }

    public string? RedemptionMsgTemplateContentVn { get; set; }

    public string? RedemptionMsgTemplateContentEn { get; set; }

    public string? Status { get; set; }

    public string? VoucherGroupNameUnsign { get; set; }

    public string? GrantNotificationChannel { get; set; }

    public string? RedemptionNotificationChannel { get; set; }

    public string? TriggerEvent { get; set; }

    public string? EventFilter { get; set; }

    public bool IsDaily { get; set; }

    public string? Cron { get; set; }

    public string? TriggerType { get; set; }

    public DateTime? TriggerDate { get; set; }

    public decimal? MinBillAmount { get; set; }

    public decimal? QtyRedeemPerPerson { get; set; }

    public int? RewardTargetAudienceId { get; set; }

    public string? TargetAudienceType { get; set; }

    public bool IsEditable { get; set; }

    public int? MaxDayForPo { get; set; }

    public string? ReferralRewardReceiver { get; set; }

    public bool IsGranted { get; set; }
}
