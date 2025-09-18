using System;
using System.Collections.Generic;

namespace Infra;

public partial class RwFormulaDetail
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

    public string? FormulaHeaderCode { get; set; }

    public string? FormulaDetailCode { get; set; }

    public string? FormulaDetailName { get; set; }

    public int WarrantyByRegistrationDate { get; set; }

    public int WarrantyByProduceDate { get; set; }

    public bool IsMainDevice { get; set; }

    public int EffectRegistration { get; set; }
}
