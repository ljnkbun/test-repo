using System;
using System.Collections.Generic;

namespace Infra;

public partial class CodeGeneratorGeneratorDetail
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

    public string? GeneratorCode { get; set; }

    public int? Ordinal { get; set; }

    public string? SyntaxCode { get; set; }

    public string? ParameterValue1 { get; set; }

    public string? ParameterValue2 { get; set; }

    public string? GeneratorDetailId { get; set; }

    public string? LastValue { get; set; }
}
