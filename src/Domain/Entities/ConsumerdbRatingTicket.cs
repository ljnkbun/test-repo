using System;
using System.Collections.Generic;

namespace Infra;

public partial class ConsumerdbRatingTicket
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

    public string? OrderCode { get; set; }

    public DateTime? SubmitDate { get; set; }

    public decimal? Rating { get; set; }

    public string? Comment { get; set; }

    public decimal? OrderAmount { get; set; }

    public decimal? Point { get; set; }

    public string? MemberMobileNumber { get; set; }
}
