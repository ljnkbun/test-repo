using System;
using System.Collections.Generic;

namespace Infra;

public partial class ConsumerdbConsumerActivity
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public int TenantId { get; set; }

    public string? MemberCode { get; set; }

    public string? ActivityType { get; set; }

    public DateTime? ActivityTime { get; set; }

    public string? ReferrenceCode { get; set; }

    public string? CustomerCode { get; set; }
}
