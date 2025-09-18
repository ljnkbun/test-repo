using System;
using System.Collections.Generic;

namespace Infra;

public partial class RewardsVoucherBudget
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

    public string? VoucherGroupCode { get; set; }

    public string? VoucherGroupName { get; set; }

    public decimal? MaxRedeemQuantity { get; set; }

    public decimal? MaxGrantQuantity { get; set; }

    public decimal? GrantedQuantity { get; set; }

    public decimal? RemainGrantQuantity { get; set; }

    public decimal? RedeemedQuantity { get; set; }

    public decimal? RemainRedeemQuantity { get; set; }
}
