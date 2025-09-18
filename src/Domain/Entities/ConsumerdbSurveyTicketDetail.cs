using System;
using System.Collections.Generic;

namespace Infra;

public partial class ConsumerdbSurveyTicketDetail
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

    public string? QuestionCode { get; set; }

    public string? QuestionDescription { get; set; }

    public string? AnswerId { get; set; }

    public string? AnswerDescription { get; set; }

    public int? TimeSpend { get; set; }
}
