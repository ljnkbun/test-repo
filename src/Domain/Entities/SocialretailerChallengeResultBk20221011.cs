using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerChallengeResultBk20221011
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

    public int ChallengeId { get; set; }

    public int Status { get; set; }

    public string? Image { get; set; }

    public int ChallengePhotoDetailId { get; set; }

    public string? ImageName { get; set; }

    public bool IsLibrary { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? ApprovedTime { get; set; }

    public string? RejectReasonCode { get; set; }

    public string? RejectReasonDetail { get; set; }
}
