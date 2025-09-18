using System;
using System.Collections.Generic;

namespace Infra;

public partial class ConsumerdbDeleteProfileRequest
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

    public string? MemberCode { get; set; }

    public string? MemberName { get; set; }

    public string? Phone { get; set; }

    public string? TypeOfRequest { get; set; }

    public DateTime RequestDate { get; set; }

    public string? RequestBy { get; set; }

    public string? Credentials { get; set; }

    public string? Status { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string? ApproveBy { get; set; }

    public string? Reason { get; set; }

    public string? ReasonCode { get; set; }
}
