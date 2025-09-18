using System;
using System.Collections.Generic;

namespace Infra;

public partial class RwWarrantySerial
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

    public string? Serial { get; set; }

    public string? SerialRefCode { get; set; }

    public DateTime? SellInDate { get; set; }

    public DateTime? SellOutDate { get; set; }

    public DateTime? ManufactureDate { get; set; }

    public DateTime? RegisterDate { get; set; }

    public DateTime? InternalExpiredDateMainDevice { get; set; }

    public DateTime? PublicExpiredDateMainDevice { get; set; }

    public DateTime? InternalExpiredDateAccessory { get; set; }

    public DateTime? PublicExpiredDateAccessory { get; set; }

    public string? CustomerName { get; set; }

    public string? Phone { get; set; }

    public string? WardName { get; set; }

    public string? ProvinceName { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? ComboHeaderCode { get; set; }

    public string? FormulaHeaderCode { get; set; }

    public string? FullDeptCode { get; set; }

    public string? ProductCode { get; set; }

    public string? DistrictCode { get; set; }

    public string? DistrictName { get; set; }

    public string? ProvinceCode { get; set; }

    public string? WardCode { get; set; }

    public string? FullDeptName { get; set; }

    public string? ProductName { get; set; }

    public DateTime? SoldToDistributorDate { get; set; }

    public string? AccessoryName { get; set; }

    public string? MainDeviceName { get; set; }

    public string? Notes { get; set; }

    public string? Note { get; set; }

    public int EffectRegistration { get; set; }

    public string? SerialType { get; set; }

    public string? WarrantyCode { get; set; }

    public string? BaseSerial { get; set; }

    public DateTime? ExchangeDate { get; set; }

    public DateTime? SellDisDate { get; set; }

    public DateTime? SellVipShopDate { get; set; }

    public string? PurchaseInvoice { get; set; }
}
