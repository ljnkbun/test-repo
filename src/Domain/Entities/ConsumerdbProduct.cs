using System;
using System.Collections.Generic;

namespace Infra;

public partial class ConsumerdbProduct
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

    public string? ProductCode { get; set; }

    public string? ProductName1 { get; set; }

    public string? ProductName2 { get; set; }

    public string? HierarchyL1 { get; set; }

    public string? HierarchyL2 { get; set; }

    public string? HierarchyL3 { get; set; }

    public string? HierarchyL4 { get; set; }

    public string? HierarchyL5 { get; set; }

    public string? Status { get; set; }

    public string? ProductName2UnSign { get; set; }

    public string? ProductName1UnSign { get; set; }

    public string? ImageLink { get; set; }

    public string? ReferenceCode { get; set; }

    public string? Uomcode { get; set; }

    public decimal? OldPrice { get; set; }

    public decimal? NewPrice { get; set; }

    public string? Description { get; set; }

    public bool IsNew { get; set; }

    public string? Tag { get; set; }

    public string? ContentVn { get; set; }

    public string? ContentEn { get; set; }

    public string? LinkDirect { get; set; }

    public bool IsFeature { get; set; }

    public string? HierarchyFullLevel { get; set; }

    public bool IsOnApp { get; set; }

    public int SellingType { get; set; }

    public string? BackupProductName1 { get; set; }

    public string? BackupProductName1UnSign { get; set; }
}
