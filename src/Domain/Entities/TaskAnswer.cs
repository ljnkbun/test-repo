using System;
using System.Collections.Generic;

namespace Infra;

public partial class TaskAnswer
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

    public string? AnswerCode { get; set; }

    public string? TaskCode { get; set; }

    public string QuestionCode { get; set; } = null!;

    public string? ImageLink { get; set; }

    public string? ContentEn { get; set; }

    public string? ContentVn { get; set; }
}
