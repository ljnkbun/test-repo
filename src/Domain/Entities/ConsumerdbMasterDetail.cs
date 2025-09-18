using System;
using System.Collections.Generic;

namespace Infra;

public partial class ConsumerdbMasterDetail
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

    public string? DetailCode { get; set; }

    public string? ParentCode { get; set; }

    public string? NodePath { get; set; }

    public int? Ordinal { get; set; }

    public string? Status { get; set; }

    public decimal? DetailValueNumber { get; set; }

    public int? Level { get; set; }

    public string? DetailValue { get; set; }

    public string? DetailValueUnSign { get; set; }

    public string? DetailImage { get; set; }
}
