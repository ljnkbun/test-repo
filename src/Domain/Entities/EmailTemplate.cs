using System;
using System.Collections.Generic;

namespace Infra;

public partial class EmailTemplate
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

    public string? Title { get; set; }

    public string? Body { get; set; }

    public string? Preview { get; set; }

    public int? CommunicationId { get; set; }

    public virtual CommunicationCommunication? Communication { get; set; }
}
