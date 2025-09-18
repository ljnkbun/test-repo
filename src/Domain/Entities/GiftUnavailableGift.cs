using System;
using System.Collections.Generic;

namespace Infra;

public partial class GiftUnavailableGift
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public int TenantId { get; set; }

    public string? GiftCampaignCode { get; set; }

    public string? OutletCode { get; set; }

    public string? OutletName { get; set; }

    public string? ZaloChatId { get; set; }

    public DateTime? PublishDate { get; set; }

    public DateTime? RequestDate { get; set; }

    public string? GiftMasterCode { get; set; }

    public string? GiftCode { get; set; }

    public string? Status { get; set; }

    public string? TransactionId { get; set; }
}
