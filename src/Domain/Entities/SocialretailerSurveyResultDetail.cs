using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerSurveyResultDetail
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

    public int SurveyDetailId { get; set; }

    public int SurveyResultId { get; set; }

    public string? Value { get; set; }

    public string? QuestionType { get; set; }
}
