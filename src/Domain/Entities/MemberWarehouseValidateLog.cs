using System;
using System.Collections.Generic;

namespace Infra;

public partial class MemberWarehouseValidateLog
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

    public string? MemberCode { get; set; }

    public string? CurrentLat { get; set; }

    public string? CurrentLng { get; set; }

    public string? CompareLat { get; set; }

    public string? CompareLng { get; set; }

    public long? MemberWarehouseId { get; set; }

    public string? MemberWarehouseName { get; set; }

    public long? Distance { get; set; }

    public string? Message { get; set; }

    public bool IsMockGps { get; set; }
}
