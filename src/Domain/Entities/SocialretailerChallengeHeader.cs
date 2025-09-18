using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerChallengeHeader
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

    public string? Code { get; set; }

    public string? Type { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public DateTime EffectFrom { get; set; }

    public DateTime EffectTo { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    public int TargetAudienceId { get; set; }

    public string? TargetAudienceType { get; set; }

    public DateTime? RegisterFromDate { get; set; }

    public DateTime? RegisterToDate { get; set; }
}
