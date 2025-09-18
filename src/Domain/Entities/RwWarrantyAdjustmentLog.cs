using System;
using System.Collections.Generic;

namespace Infra;

public partial class RwWarrantyAdjustmentLog
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

    public string? Approver { get; set; }

    public string? Serial { get; set; }

    public DateTime? OldInternalExpiredDateMainDevice { get; set; }

    public DateTime? OldPublicExpiredDateMainDevice { get; set; }

    public DateTime? OldInternalExpiredDateAccessory { get; set; }

    public DateTime? OldPublicExpiredDateAccessory { get; set; }

    public DateTime? NewInternalExpiredDateMainDevice { get; set; }

    public DateTime? NewPublicExpiredDateMainDevice { get; set; }

    public DateTime? NewInternalExpiredDateAccessory { get; set; }

    public DateTime? NewPublicExpiredDateAccessory { get; set; }

    public DateTime? BusinessDate { get; set; }

    public string? Description { get; set; }

    public string? Source { get; set; }

    public string? NewAddress { get; set; }

    public string? NewCustomerName { get; set; }

    public string? NewDistrictCode { get; set; }

    public string? NewDistrictName { get; set; }

    public string? NewEmail { get; set; }

    public string? NewPhone { get; set; }

    public string? NewProvinceCode { get; set; }

    public string? NewProvinceName { get; set; }

    public string? OldAddress { get; set; }

    public string? OldCustomerName { get; set; }

    public string? OldDistrictCode { get; set; }

    public string? OldDistrictName { get; set; }

    public string? OldEmail { get; set; }

    public string? OldPhone { get; set; }

    public string? OldProvinceCode { get; set; }

    public string? OldProvinceName { get; set; }

    public int NewEffectRegistration { get; set; }

    public int OldEffectRegistration { get; set; }
}
