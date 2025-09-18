using System;
using System.Collections.Generic;

namespace Infra;

public partial class ScanSerialRequestTransaction
{
    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int Id { get; set; }

    public int UserId { get; set; }

    public int TenantId { get; set; }

    public string? Serial { get; set; }

    public string? ReferenceId { get; set; }

    public string? MemberCode { get; set; }

    public string? MemberName { get; set; }

    public string? VehicleNumber { get; set; }

    public string? ModelCode { get; set; }

    public string? Message { get; set; }

    public string? IsDistributorTemp { get; set; }

    public bool Importing { get; set; }

    public string? Status { get; set; }
}
