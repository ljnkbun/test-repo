using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerComponentRuler
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public string? Name { get; set; }

    public int? LimitLength { get; set; }

    public string? Type { get; set; }

    public string? Value { get; set; }

    public bool IsActive { get; set; }

    public int Order { get; set; }

    public int RuleGeneratorId { get; set; }

    public virtual SocialretailerRuleGenerator RuleGenerator { get; set; } = null!;
}
