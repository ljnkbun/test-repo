using System;
using System.Collections.Generic;

namespace Infra;

public partial class RwComboDetail
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

    public string? ComboHeaderCode { get; set; }

    public string? ComboDetailCode { get; set; }

    public string? MainDeviceName { get; set; }

    public string? AccessoryName { get; set; }

    public string? ColdDeviceName { get; set; }

    public string? ComboType { get; set; }

    public string? HotDeviceName { get; set; }
}
