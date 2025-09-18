using System;
using System.Collections.Generic;

namespace Infra;

public partial class PointTempInvoiceTransaction
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

    public string? DistCd { get; set; }

    public string? CustCd { get; set; }

    public string? SlsmanCd { get; set; }

    public string? InvNo { get; set; }

    public string? InvKey { get; set; }

    public string? SoNo { get; set; }

    public string? SoKey { get; set; }

    public string? TinvNo { get; set; }

    public string? WhsCd { get; set; }

    public string? InvType { get; set; }

    public string? InvInd { get; set; }

    public string? BilltoCd { get; set; }

    public string? ShiptoCd { get; set; }

    public string? DistTaxId { get; set; }

    public string? CustTaxregno { get; set; }

    public string? CustMunicipalno { get; set; }

    public string? SubdistInd { get; set; }

    public string? CustType { get; set; }

    public string? PoNo { get; set; }

    public DateTime? SoDt { get; set; }

    public DateTime? InvDt { get; set; }

    public DateTime? CreateDt { get; set; }

    public DateTime? DeliveryDt { get; set; }

    public string? BuCd { get; set; }

    public string? InvtermCd { get; set; }

    public string? InvStatus { get; set; }

    public string? RefNo { get; set; }

    public string? TaxInvNo { get; set; }

    public decimal? GrossTtl { get; set; }

    public decimal? NetTtl { get; set; }

    public decimal? NetTtlTax { get; set; }

    public decimal? AdjAmt { get; set; }

    public decimal? TaxableAmt { get; set; }

    public decimal? TaxableAmtFoc { get; set; }

    public decimal? NontaxableAmt { get; set; }

    public decimal? TaxPerc1 { get; set; }

    public decimal? TaxPerc2 { get; set; }

    public decimal? TaxPerc3 { get; set; }

    public decimal? TaxTtl1 { get; set; }

    public decimal? TaxTtl2 { get; set; }

    public decimal? TaxTtl3 { get; set; }

    public decimal? TaxTtl { get; set; }

    public decimal? PrcTaxTtl1 { get; set; }

    public decimal? PrcTaxTtl2 { get; set; }

    public decimal? PrcTaxTtl3 { get; set; }

    public decimal? PrcTaxTtl { get; set; }

    public decimal? CustDiscPerc { get; set; }

    public decimal? CustDiscAmt { get; set; }

    public decimal? PrdDiscTtl { get; set; }

    public decimal? ClaimDisc { get; set; }

    public decimal? DistDisc { get; set; }

    public decimal? PromoDisc { get; set; }

    public decimal? SlsDisc { get; set; }

    public decimal? CashDisc { get; set; }

    public decimal? CustGrpDisc { get; set; }

    public decimal? AddTaxAmt { get; set; }

    public string? Remark { get; set; }

    public string? UpldwStatus { get; set; }

    public DateTime? SvrUpldwDt { get; set; }

    public string? CreatedBy { get; set; }

    public string? SvrClient { get; set; }

    public DateTime? HhtSubmitDt { get; set; }

    public string? VisitKey { get; set; }

    public decimal? PrnNo { get; set; }

    public decimal? PrnNoTax { get; set; }

    public bool PicklistInd { get; set; }

    public bool NpclaimInd { get; set; }

    public bool SpclaimInd { get; set; }

    public string? DeInd { get; set; }

    public DateTime? DeDt { get; set; }

    public string? ExtInd { get; set; }

    public string? FullReversalInd { get; set; }

    public decimal? Version { get; set; }

    public DateTime? Syncversion { get; set; }

    public string? Ind { get; set; }

    public decimal? PrnDoNo { get; set; }

    public bool ErpInd { get; set; }

    public string? AgentCd { get; set; }

    public DateTime? DwDt { get; set; }

    public decimal? InvDiscTtl { get; set; }

    public string? PrdCd { get; set; }

    public string? PrdSlstype { get; set; }

    public int? PrdIndex { get; set; }

    public string? UomCd1 { get; set; }

    public string? UomCd2 { get; set; }

    public string? UomCd3 { get; set; }

    public bool TaxInd { get; set; }

    public string? PrcTaxInd { get; set; }

    public string? DefUomCd { get; set; }

    public decimal? PrdQty1 { get; set; }

    public decimal? PrdQty2 { get; set; }

    public decimal? PrdQty3 { get; set; }

    public decimal? Mrp { get; set; }

    public decimal? Cp { get; set; }

    public decimal? PrdListprc { get; set; }

    public decimal? UomListprc1 { get; set; }

    public decimal? UomListprc2 { get; set; }

    public decimal? UomListprc3 { get; set; }

    public decimal? PrcTaxPerc1 { get; set; }

    public decimal? PrcTaxPerc2 { get; set; }

    public decimal? PrcTaxPerc3 { get; set; }

    public decimal? PrcTaxAmt1 { get; set; }

    public decimal? PrcTaxAmt2 { get; set; }

    public decimal? PrcTaxAmt3 { get; set; }

    public decimal? PrcTaxAmt { get; set; }

    public decimal? PrdDisc { get; set; }

    public decimal? GrossAmt { get; set; }

    public decimal? PromoDiscDtl { get; set; }

    public decimal? DistPromoDisc { get; set; }

    public decimal? HqPromoDisc { get; set; }

    public decimal? SlsDiscDtl { get; set; }

    public decimal? CustGrpDiscDtl { get; set; }

    public decimal? CashDiscPerc { get; set; }

    public decimal? CashDiscDtl { get; set; }

    public decimal? UnitTax { get; set; }

    public decimal? NetAmt { get; set; }

    public decimal? NetAmtTax { get; set; }

    public decimal? NetAmtFoc { get; set; }

    public decimal? CustDiscDtl { get; set; }

    public decimal? TaxPerc1Dtl { get; set; }

    public decimal? TaxPerc2Dtl { get; set; }

    public decimal? TaxPerc3Dtl { get; set; }

    public decimal? TaxAmt1 { get; set; }

    public decimal? TaxAmt2 { get; set; }

    public decimal? TaxAmt3 { get; set; }

    public decimal? TaxAmt { get; set; }

    public decimal? AddTaxPerc { get; set; }

    public decimal? AddTaxAmtDtl { get; set; }

    public decimal? PurchaseRate { get; set; }

    public decimal? DistDiscDtl { get; set; }

    public decimal? UomConvFactorSml1 { get; set; }

    public decimal? UomConvFactorSml2 { get; set; }

    public decimal? UomConvFactorSml3 { get; set; }

    public string? IndDtl { get; set; }

    public string? ParentPrd { get; set; }

    public string? ParentUom { get; set; }

    public string? MyTaxCd { get; set; }

    public decimal? PriceError { get; set; }

    public string? MslInd { get; set; }

    public decimal? InvDisc { get; set; }
}
