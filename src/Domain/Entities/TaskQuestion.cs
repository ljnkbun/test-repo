using System;
using System.Collections.Generic;

namespace Infra;

public partial class TaskQuestion
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

    public string? ImageFullLink { get; set; }

    public string? TaskCode { get; set; }

    public string? QuestionType { get; set; }

    public int? Ordering { get; set; }

    public bool Required { get; set; }

    public bool AttachImage { get; set; }

    public float? Maxvalue { get; set; }

    public float? Minvalue { get; set; }

    public string? ContentEn { get; set; }

    public string? ContentVn { get; set; }

    public string? ImageHaftLink { get; set; }

    public string? ImageNoneLink { get; set; }

    public float? StepPass { get; set; }

    public string? TaskMasterCode { get; set; }

    public string? Department { get; set; }

    public int ActionId { get; set; }
}
