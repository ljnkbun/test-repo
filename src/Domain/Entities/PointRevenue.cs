using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointRevenue
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int? TenantId { get; set; }

    public long TotalInvoice { get; set; }

    public decimal TotalAmount { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public DateTime CalculateDate { get; set; }
}
