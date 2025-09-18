using System;
using System.Collections.Generic;

namespace Infra;

public partial class ConsumerdbSurveySetting
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

    public string? SurveyName { get; set; }

    public string? SurveyMonkeyCode { get; set; }

    public DateTime? EffectiveFrom { get; set; }

    public DateTime? EffectiveTo { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public string? ImageLink { get; set; }

    public string? SurveyNameUnsign { get; set; }
}
