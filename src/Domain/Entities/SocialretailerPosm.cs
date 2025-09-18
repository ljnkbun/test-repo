using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerPosm
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

    public string ImagePath { get; set; } = null!;

    public string? Description { get; set; }

    public int Quantity { get; set; }

    public string Posmtype { get; set; } = null!;

    public int PosmresultId { get; set; }

    public string? CreatorName { get; set; }

    public string? LastModifierName { get; set; }

    public string? Brand { get; set; }

    public string? DetailCode { get; set; }

    public string? MemberCode { get; set; }

    public string? ProductType { get; set; }
}
