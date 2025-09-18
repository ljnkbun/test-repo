using System;
using System.Collections.Generic;

namespace Infra;

public partial class RwActionLog
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

    public int UserId { get; set; }

    public DateTime? ActionDate { get; set; }

    public string? ActionType { get; set; }

    public string? TableName { get; set; }

    public string? ColumnName { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }
}
