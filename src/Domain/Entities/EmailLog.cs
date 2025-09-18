using System;
using System.Collections.Generic;

namespace Infra;

public partial class EmailLog
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public string? EmailFrom { get; set; }

    public string? EmailTo { get; set; }

    public string? EmailCc { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public string? FileName { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectId { get; set; }

    public string? ObjectDataJson { get; set; }

    public int Status { get; set; }

    public int? TenantId { get; set; }
}
