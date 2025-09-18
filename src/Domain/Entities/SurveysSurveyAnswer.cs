using System;
using System.Collections.Generic;

namespace Infra;

public partial class SurveysSurveyAnswer
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

    public string QuestionCode { get; set; } = null!;

    public string? ContentVn { get; set; }

    public string? ImageLink { get; set; }

    public string? SurveyCode { get; set; }

    public string? AnswerCode { get; set; }

    public string? ContentEn { get; set; }
}
