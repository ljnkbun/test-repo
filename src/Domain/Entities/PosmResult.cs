using System;
using System.Collections.Generic;

namespace Infra;

public partial class PosmResult
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

    public string? SalemanCode { get; set; }

    public string? OutletCode { get; set; }

    public string? CheckInLongitude { get; set; }

    public string? CheckInLatitude { get; set; }

    public string? CheckOutLongitude { get; set; }

    public string? CheckOutLatitude { get; set; }

    public string? CheckInDistance { get; set; }

    public string? CheckOutDistance { get; set; }

    public string? CheckInImageLink { get; set; }

    public string? CheckOutImageLink { get; set; }

    public DateTime CheckInTime { get; set; }

    public DateTime CheckOutTime { get; set; }

    public string? CreatorName { get; set; }

    public string? LastModifierName { get; set; }

    public int PosmId { get; set; }

    public int VisitPlanResultId { get; set; }
}
