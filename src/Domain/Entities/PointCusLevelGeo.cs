using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointCusLevelGeo
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

    public string? SlsRegionLevel8 { get; set; }

    public string? SlsRegionLevel7 { get; set; }

    public string? SlsRegionLevel6 { get; set; }

    public string? SlsRegionLevel5 { get; set; }

    public string? SlsRegionLevel4 { get; set; }

    public string? SlsRegionLevel3 { get; set; }

    public string? SlsRegionLevel2 { get; set; }

    public string? SlsRegionLevel1 { get; set; }

    public string? NameLevel8 { get; set; }

    public string? NameLevel7 { get; set; }

    public string? NameLevel6 { get; set; }

    public string? NameLevel5 { get; set; }

    public string? NameLevel4 { get; set; }

    public string? NameLevel3 { get; set; }

    public string? NameLevel2 { get; set; }

    public string? NameLevel1 { get; set; }

    public string? CustCd { get; set; }
}
