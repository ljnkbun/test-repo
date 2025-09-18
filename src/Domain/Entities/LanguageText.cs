using System;
using System.Collections.Generic;

namespace Infra;

public partial class LanguageText
{
    public long Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public int? TenantId { get; set; }

    public string LanguageName { get; set; } = null!;

    public string Source { get; set; } = null!;

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;
}
