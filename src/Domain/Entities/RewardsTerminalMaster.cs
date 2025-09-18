using System;
using System.Collections.Generic;

namespace Infra;

public partial class RewardsTerminalMaster
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

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Status { get; set; }

    public string? ReferenceCode { get; set; }

    public string? TerminalCode { get; set; }

    public string? TerminalName { get; set; }

    public string? TerminalNameUnsign { get; set; }

    public string? FullSalesRegion { get; set; }

    public string? ProductHierarchyLv1 { get; set; }

    public string? ProductHierarchyLv2 { get; set; }

    public string? ProductHierarchyLv3 { get; set; }

    public string? ProductHierarchyLv4 { get; set; }

    public string? ProductHierarchyLv5 { get; set; }
}
