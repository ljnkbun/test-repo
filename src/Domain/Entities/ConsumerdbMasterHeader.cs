using System;
using System.Collections.Generic;

namespace Infra;

public partial class ConsumerdbMasterHeader
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

    public string? MasterCode { get; set; }

    public string? MasterName { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public bool IsSystem { get; set; }

    public string? MasterNameUnSign { get; set; }
}
