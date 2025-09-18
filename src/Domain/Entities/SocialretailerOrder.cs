using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerOrder
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

    public string? OrderStatus { get; set; }

    public int PartnerId { get; set; }

    public DateTime AppointmentDate { get; set; }

    public string? Description { get; set; }

    public string? CreatorName { get; set; }

    public string? LastModifierName { get; set; }

    public string? OrderCode { get; set; }

    public string? PartnerName { get; set; }
}
