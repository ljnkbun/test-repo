using System;
using System.Collections.Generic;

namespace Infra;

public partial class Tenant
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public string TenancyName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? ConnectionString { get; set; }

    public bool IsActive { get; set; }

    public int? EditionId { get; set; }

    public DateTime? SubscriptionEndDateUtc { get; set; }

    public bool IsInTrialPeriod { get; set; }

    public Guid? CustomCssId { get; set; }

    public Guid? LogoId { get; set; }

    public string? LogoFileType { get; set; }

    public virtual User? CreatorUser { get; set; }

    public virtual User? DeleterUser { get; set; }

    public virtual Edition? Edition { get; set; }

    public virtual User? LastModifierUser { get; set; }
}
