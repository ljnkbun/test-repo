using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerSerialOutSaphistory
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

    public string? Serial { get; set; }

    public string? ProductCode { get; set; }

    public string? Distributor { get; set; }

    public string? ReferenceId { get; set; }

    public string? Department { get; set; }

    public string? SalesChannel { get; set; }

    public string? Region { get; set; }

    public DateTime ExportDate { get; set; }

    public string? VehicleNumber { get; set; }

    public string? Reason { get; set; }

    public string? Action { get; set; }

    public string? CreatorName { get; set; }
}
