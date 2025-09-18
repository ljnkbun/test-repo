using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerRuleGenerator
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

    public string? Model { get; set; }

    public bool IsGenerateActivationCode { get; set; }

    public string? RuleType { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<SocialretailerComponentRuler> SocialretailerComponentRulers { get; set; } = new List<SocialretailerComponentRuler>();
}
