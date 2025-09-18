using System;
using System.Collections.Generic;

namespace Infra;

public partial class ConsumerdbQaticket
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public int TenantId { get; set; }

    public string? TicketCode { get; set; }

    public string? MemberCode { get; set; }

    public string? MemberName { get; set; }

    public DateTime? SubmitDate { get; set; }

    public string? Content { get; set; }

    public string? MemberNameUnsign { get; set; }

    public string? Type { get; set; }
}
