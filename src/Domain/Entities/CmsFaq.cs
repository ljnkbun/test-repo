using System;
using System.Collections.Generic;

namespace Infra;

public partial class CmsFaq
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public int? TenantId { get; set; }

    public string Code { get; set; } = null!;

    public int? Ordinal { get; set; }

    public virtual ICollection<CmsFaqtranslation> CmsFaqtranslations { get; set; } = new List<CmsFaqtranslation>();
}
