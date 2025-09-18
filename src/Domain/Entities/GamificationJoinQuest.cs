using System;
using System.Collections.Generic;

namespace Infra;

public partial class GamificationJoinQuest
{
    public string QuestCode { get; set; } = null!;

    public string MemberCode { get; set; } = null!;

    public int TenantId { get; set; }

    public string? Code { get; set; }

    public string? State { get; set; }

    public DateTime Date { get; set; }
}
