using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerSalesDataBaseline
{
    public string Serial { get; set; } = null!;

    public string? ProductCode { get; set; }

    public string? DeptName1 { get; set; }

    public string? DeptName2 { get; set; }

    public string? DeptName3 { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public string? DistributorCode { get; set; }

    public string? DistributorName { get; set; }

    public string? DistributorProvinceCode { get; set; }

    public string? DistributorProvinceName { get; set; }

    public DateTime? ExportDate { get; set; }

    public DateTime? DistributorSellthruDate { get; set; }

    public string? DistributorPhoneNumber { get; set; }

    public string? VipShopCode { get; set; }

    public string? VipShopName { get; set; }

    public DateTime? VipShopSellthruDate { get; set; }

    public string? VipShopPhoneNumber { get; set; }

    public string? VipShopProvinceCode { get; set; }

    public string? VipShopProvinceName { get; set; }

    public string? MemberCode { get; set; }

    public string? MemberName { get; set; }

    public DateTime? SellInDate { get; set; }

    public string? MemberPhoneNumber { get; set; }

    public string? MemberProvinceCode { get; set; }

    public string? MemberProvinceName { get; set; }

    public string? SalesmanCode { get; set; }

    public string? SalesmanName { get; set; }

    public DateTime? SellOutDate { get; set; }

    public string? SalesmanPhoneNumber { get; set; }

    public string? SalesmanProvinceCode { get; set; }

    public string? SalesmanProvinceName { get; set; }

    public string? PaymentName { get; set; }

    public DateTime? WarrantyRegisterDate { get; set; }
}
