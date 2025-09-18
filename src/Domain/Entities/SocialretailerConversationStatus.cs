using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerConversationStatus
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public int TenantId { get; set; }

    public string? RetailerCode { get; set; }

    public string? UserId { get; set; }
}
