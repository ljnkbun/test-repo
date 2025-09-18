using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerUserImporting
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

    public bool Importing { get; set; }

    public int RowImport { get; set; }

    public int TotalRowImport { get; set; }

    public string? LinkFileImport { get; set; }

    public int TotalRowSuccess { get; set; }

    public int TotalRowError { get; set; }

    public DateTime? LastDateImporting { get; set; }

    public string? Type { get; set; }
}
