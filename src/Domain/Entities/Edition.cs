using System;
using System.Collections.Generic;

namespace Infra;

public partial class Edition
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string Discriminator { get; set; } = null!;

    public int? ExpiringEditionId { get; set; }

    public decimal? MonthlyPrice { get; set; }

    public decimal? AnnualPrice { get; set; }

    public int? TrialDayCount { get; set; }

    public int? WaitingDayAfterExpire { get; set; }

    public virtual ICollection<AppSubscriptionPayment> AppSubscriptionPayments { get; set; } = new List<AppSubscriptionPayment>();

    public virtual ICollection<Feature> Features { get; set; } = new List<Feature>();

    public virtual ICollection<Tenant> Tenants { get; set; } = new List<Tenant>();
}
