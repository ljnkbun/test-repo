using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerRequest
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

    public string RequestCode { get; set; } = null!;

    public string RequestType { get; set; } = null!;

    public string RequestStatus { get; set; } = null!;

    public int Step { get; set; }

    public string Description { get; set; } = null!;

    public string? CreatorName { get; set; }

    public string? LastModifierName { get; set; }

    public string? MemberName { get; set; }

    public int AssignerId { get; set; }

    public string? AssignerName { get; set; }

    public int TotalStep { get; set; }

    public string? MemberCode { get; set; }

    public string? BeatPlanCode { get; set; }

    public string? Unsign { get; set; }

    public string? RejectMessage { get; set; }

    public int MemberWarehouseId { get; set; }
}
