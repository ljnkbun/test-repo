using System;
using System.Collections.Generic;

namespace Infra;

public partial class CmsVideo
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

    public string? NameVn { get; set; }

    public string? NameEn { get; set; }

    public string? DescriptionVn { get; set; }

    public string? DescriptionEn { get; set; }

    public string? VideoLink { get; set; }

    public string? Avatar { get; set; }

    public string? LinkAvatar { get; set; }

    public string? Status { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Tags { get; set; }

    public bool IsOnApp { get; set; }

    public int? Ordinal { get; set; }
}
