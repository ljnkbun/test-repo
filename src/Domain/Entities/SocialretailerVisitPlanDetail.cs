using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerVisitPlanDetail
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public string? DistCd { get; set; }

    public string? SlsmanCd { get; set; }

    public string? CycleCd { get; set; }

    public DateTime? VisitDt { get; set; }

    public string? CustCd { get; set; }

    public int? VisitWeek { get; set; }

    public string? DuplicateInd { get; set; }

    public string? UpldwStatus { get; set; }

    public DateTime? SvrUpldwDt { get; set; }

    public int? Version { get; set; }

    public string? Syncoperation { get; set; }

    public DateTime? Syncversion { get; set; }

    public string? Syncflag { get; set; }

    public int? RouteCustSeq { get; set; }

    public int? ActualSeq { get; set; }

    public string? RsInd { get; set; }
}
