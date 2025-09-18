using System;
using System.Collections.Generic;

namespace Infra;

public partial class CmsArticleUser
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

    public string? ArticleCode { get; set; }

    public string? CategoryCode { get; set; }

    public int? CategoryType { get; set; }

    public string? Status { get; set; }
}
