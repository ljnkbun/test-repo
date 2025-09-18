using System;
using System.Collections.Generic;

namespace Infra;

public partial class RewardsPublisherMaster
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

    public string? PublisherCode { get; set; }

    public string? PublisherName { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public string? PulisherNameUnsign { get; set; }
}
