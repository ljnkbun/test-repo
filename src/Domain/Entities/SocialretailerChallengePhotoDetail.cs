using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerChallengePhotoDetail
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

    public int ChallengeId { get; set; }

    public string? NameOfPhoto { get; set; }

    public string? ImageDemo { get; set; }

    public bool IsLibrary { get; set; }

    public string? ApprovedTime { get; set; }

    public int Number { get; set; }

    public DateTime? WorkFromDate { get; set; }

    public DateTime? WorkToDate { get; set; }
}
