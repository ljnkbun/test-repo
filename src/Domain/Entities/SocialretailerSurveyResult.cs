using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerSurveyResult
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

    public int SurveyId { get; set; }

    public string? CreatorName { get; set; }

    public string? LastModifierName { get; set; }
}
