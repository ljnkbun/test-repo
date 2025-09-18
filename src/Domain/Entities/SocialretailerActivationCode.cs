using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerActivationCode
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

    public string? Code { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ActiveDate { get; set; }

    public string? CreatedBy { get; set; }

    public bool? ClearDup { get; set; }

    public string? Serial { get; set; }

    public string? MassOrder { get; set; }

    public bool? IsCancel { get; set; }

    public string? Note { get; set; }
}
