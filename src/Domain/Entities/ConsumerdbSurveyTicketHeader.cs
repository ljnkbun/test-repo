using System;
using System.Collections.Generic;

namespace Infra;

public partial class ConsumerdbSurveyTicketHeader
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

    public string? SurveyTransactionCode { get; set; }

    public string? SurveyMonkeyCode { get; set; }

    public string? SurveyUser { get; set; }

    public DateTime? StartDate { get; set; }

    public int? SurveyTime { get; set; }

    public string? Status { get; set; }

    public string? ReferenceCode { get; set; }
}
