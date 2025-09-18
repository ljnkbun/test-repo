using System;
using System.Collections.Generic;

namespace Infra;

public partial class CmsArticle
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

    public string Code { get; set; } = null!;

    public string? Avatar { get; set; }

    public string? LinkAvatar { get; set; }

    public string? Status { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Tags { get; set; }

    public int? TargetAudienceId { get; set; }

    public string? TargetAudienceType { get; set; }

    public string? Category { get; set; }

    public bool IsPined { get; set; }
}
