using System;
using System.Collections.Generic;

namespace Infra;

public partial class GamificationClaimMission
{
    public string MissionCode { get; set; } = null!;

    public string MemberCode { get; set; } = null!;

    public int TenantId { get; set; }

    public string? Code { get; set; }

    public string? QuestCode { get; set; }

    public string? State { get; set; }

    public DateTime Date { get; set; }

    public long TransactionId { get; set; }

    public string? TransactionCode { get; set; }

    public DateTime CreationTime { get; set; }
}
