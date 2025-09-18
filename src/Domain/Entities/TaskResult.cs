using System;
using System.Collections.Generic;

namespace Infra;

public partial class TaskResult
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public string TaskCode { get; set; } = null!;

    public string? QuestionCode { get; set; }

    public string? QuestionType { get; set; }

    public int? Ordering { get; set; }

    public string? ZaloChatId { get; set; }

    public string? QuestionContent { get; set; }

    public string? MemberCode { get; set; }

    public string? AnswerCode { get; set; }

    public string? AnswerContent { get; set; }

    public string? ImageLink { get; set; }

    public string? FacebookId { get; set; }

    public string? OutletCode { get; set; }

    public string? Subject { get; set; }

    public string? Channel { get; set; }

    public string? Email { get; set; }

    public string? MemberName { get; set; }

    public string? MessageId { get; set; }

    public string? Phone { get; set; }

    public int TenantId { get; set; }

    public int BeatPlanResultId { get; set; }

    public string? TaskMasterCode { get; set; }

    public string? Status { get; set; }
}
