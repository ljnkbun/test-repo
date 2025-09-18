using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerExtendActiveSerial
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

    public string? Serial { get; set; }

    public DateTime? EffectSellNpp { get; set; }

    public DateTime? EffectSellVipShop { get; set; }

    public DateTime? EffectSellMbs { get; set; }

    public DateTime? EffectSellSellout { get; set; }

    public string? ProposalNo { get; set; }

    public string? Submitter { get; set; }

    public string? Approver { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public string? FileImport { get; set; }
}
