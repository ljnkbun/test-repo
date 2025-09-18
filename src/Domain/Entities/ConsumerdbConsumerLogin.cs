using System;
using System.Collections.Generic;

namespace Infra;

public partial class ConsumerdbConsumerLogin
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public int TenantId { get; set; }

    public string? MemberCode { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? FacebookId { get; set; }

    public string? GoogleId { get; set; }

    public bool IsLogOut { get; set; }

    public string? DeviceId { get; set; }

    public DateTime? LastLogin { get; set; }
}
