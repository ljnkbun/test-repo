using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointProductUommapping
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public int TenantId { get; set; }

    public string? PrdCd { get; set; }

    public string? UomCd { get; set; }

    public string? BaseuomCd { get; set; }

    public int? UomLevel { get; set; }

    public int? ConvFactor { get; set; }

    public int? ConvFactorSml { get; set; }

    public int? PackLength { get; set; }

    public int? PackWidth { get; set; }

    public int? PackHeight { get; set; }

    public string? DimensionUnit { get; set; }

    public int? NetWeight { get; set; }

    public int? GrossWeight { get; set; }

    public string? WeightUnit { get; set; }
}
