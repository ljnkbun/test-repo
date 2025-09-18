using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerSalesDatum
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

    public decimal SellOutPoint { get; set; }

    public decimal SellInCoin { get; set; }

    public decimal SellOutCoin { get; set; }

    public string? CampaignNames { get; set; }

    public string? CampaignCodes { get; set; }

    public string? DistributorCode { get; set; }

    public string? DistributorName { get; set; }

    public DateTime ExportDate { get; set; }

    public string? CustomerCode { get; set; }

    public DateTime TransferDate { get; set; }

    public string? RetailerCode { get; set; }

    public string? RetailerName { get; set; }

    public DateTime SoldDate { get; set; }

    public string? MemberCode { get; set; }

    public string? MemberName { get; set; }

    public string? ActivationCode { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public DateTime ActiveDate { get; set; }

    public string? SalesmanPhoneNumber { get; set; }

    public string? WardCode { get; set; }

    public string? SalesmanProvinceName { get; set; }

    public string? WardName { get; set; }

    public string? DeptCodeL1 { get; set; }

    public string? DeptName1 { get; set; }

    public string? DeptCodeL2 { get; set; }

    public string? DeptName2 { get; set; }

    public string? DeptCodeL3 { get; set; }

    public string? DeptName3 { get; set; }

    public string? DeptCodeL4 { get; set; }

    public string? DeptName4 { get; set; }

    public string? DeptCodeL5 { get; set; }

    public string? DeptName5 { get; set; }

    public string? DeptCodeL6 { get; set; }

    public string? DeptName6 { get; set; }

    public string? PaymentCode { get; set; }

    public string? PaymentName { get; set; }

    public DateTime SellInDate { get; set; }

    public DateTime SellOutDate { get; set; }

    public string? CustomerName { get; set; }

    public string? DistrictCode { get; set; }

    public string? DistrictName { get; set; }

    public string? SalesmanProvinceCode { get; set; }

    public string? SaleType { get; set; }

    public string? DistributorProvinceCode { get; set; }

    public string? DistributorProvinceName { get; set; }

    public string? MemberPhoneNumber { get; set; }

    public string? MemberProvinceCode { get; set; }

    public string? MemberProvinceName { get; set; }

    public string? SalesmanCode { get; set; }

    public string? SalesmanName { get; set; }

    public int Year { get; set; }

    public string? Mbsmembercode { get; set; }

    public string? Msbname { get; set; }

    public string? Mbsphone { get; set; }

    public string? Mbsprovince { get; set; }

    public string? MbsprovinceName { get; set; }

    public DateTime SellDisDate { get; set; }

    public DateTime SellVipShopDate { get; set; }
}
