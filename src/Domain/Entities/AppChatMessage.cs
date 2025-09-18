using System;
using System.Collections.Generic;

namespace Infra;

public partial class AppChatMessage
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public int? TenantId { get; set; }

    public long TargetUserId { get; set; }

    public int? TargetTenantId { get; set; }

    public string Message { get; set; } = null!;

    public DateTime CreationTime { get; set; }

    public int Side { get; set; }

    public int ReadState { get; set; }

    public int ReceiverReadState { get; set; }

    public Guid? SharedMessageId { get; set; }
}
