using System;
using System.Collections.Generic;

namespace Infra;

public partial class TaskResultDetail
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

    public int TaskResultId { get; set; }

    public int BeatPlanResultId { get; set; }

    public string? TaskMasterCode { get; set; }

    public string? QuestionType { get; set; }

    public string? QuestionCode { get; set; }

    public string? QuestionContent { get; set; }

    public string? AnswerCode { get; set; }

    public string? AnswerContent { get; set; }

    public string? ResultContent { get; set; }

    public string? Status { get; set; }

    public string? Reason { get; set; }

    public int ActionId { get; set; }

    public string? Department { get; set; }

    public int? Ordering { get; set; }

    public string? ImageNoneLink { get; set; }

    public string? ImageHaftLink { get; set; }

    public string? ImageFullLink { get; set; }

    public float? Minvalue { get; set; }

    public float? Maxvalue { get; set; }

    public float? StepPass { get; set; }

    public bool Required { get; set; }
}
