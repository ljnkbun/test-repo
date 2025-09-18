using System;
using System.Collections.Generic;

namespace Infra;

public partial class ConsumerdbAppBehaviorLog
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public int TenantId { get; set; }

    public string? MemberCode { get; set; }

    public string? DeviceImei { get; set; }

    public string? DeviceSerial { get; set; }

    public string? DeviceName { get; set; }

    public string? DeviceManufacturer { get; set; }

    public string? DeviceOs { get; set; }

    public string? DeviceOsversion { get; set; }

    public string? AppName { get; set; }

    public string? AppVersion { get; set; }

    public string? AppArea { get; set; }

    public string? ActionInfo { get; set; }

    public string? ActionName { get; set; }

    public DateTime? ActionStartTime { get; set; }

    public DateTime? ActionEndTime { get; set; }

    public string? Description { get; set; }
}
