using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerChallengeTargetAudience
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public int TenantId { get; set; }

    public string? TargetAudienceName { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }
}
