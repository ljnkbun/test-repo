using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerSurvey
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

    public string? Name { get; set; }

    public string? Status { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public int ObjectCollectionId { get; set; }

    public string? CreatorName { get; set; }

    public string? LastModifierName { get; set; }

    public string? ListObjectCollectionValueId { get; set; }
}
