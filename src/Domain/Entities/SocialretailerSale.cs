using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerSale
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

    public int PaymentStatus { get; set; }

    public string? ReferenceId { get; set; }

    public string? Serial { get; set; }

    public string? SaleType { get; set; }

    public string? Status { get; set; }

    public string? Description { get; set; }

    public string? Source { get; set; }

    public decimal SystemPoint { get; set; }

    public string? Address { get; set; }

    public string? ActivationCode { get; set; }

    public string? CustomerName { get; set; }

    public string? District { get; set; }

    public string? MemberCode { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? PhoneNumber { get; set; }

    public string? ProductCode { get; set; }

    public string? Province { get; set; }

    public string? Reason { get; set; }

    public string? Ward { get; set; }

    public string? NameUnsign { get; set; }

    public string? CampaignCodes { get; set; }

    public string? CampaignNames { get; set; }

    public decimal SystemCoin { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public string? VehicleNumber { get; set; }

    public string? CreatorName { get; set; }

    public string? MemberName { get; set; }

    public string? Model { get; set; }

    public string? ProductName { get; set; }

    public bool SyncSap { get; set; }

    public string? Department { get; set; }

    public string? Plant { get; set; }

    public string? Region { get; set; }

    public string? SalesChannel { get; set; }

    public string? BankAccountName { get; set; }

    public string? BankAccountNumber { get; set; }

    public string? BankName { get; set; }

    public string? DistrictName { get; set; }

    public string? IdentificationCardNumber { get; set; }

    public string? OutletTypeName { get; set; }

    public string? ProvinceName { get; set; }

    public string? RankOutlet { get; set; }

    public string? WardName { get; set; }

    public string? Sapcode { get; set; }

    public string? SerialType { get; set; }

    public int Quantity { get; set; }

    public string? ReturnType { get; set; }

    public short? IsNameUnsign { get; set; }

    public bool IsDistributorTemp { get; set; }

    public DateTime? ActiveDate { get; set; }

    public DateTime? DatabaseCreationTime { get; set; }

    public string? PhoneNumberBk { get; set; }

    public string? ReasonDelete { get; set; }

    public bool WrongRegion { get; set; }

    public string? SystemDescription { get; set; }

    public double Distance { get; set; }

    public double Lat { get; set; }

    public double Lng { get; set; }

    public int? RollBackFrom { get; set; }

    public string? PaymentNotes { get; set; }

    public bool IsRegisteredDepartment { get; set; }
}
