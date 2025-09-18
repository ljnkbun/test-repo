using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerOutletUpdateHistory
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

    public string? OutletCode { get; set; }

    public string? ReasonPhone { get; set; }

    public string? PhoneUpdated { get; set; }

    public DateTime? PhoneUpdatedDate { get; set; }

    public string? PhoneUpdateStatus { get; set; }

    public string? Otp { get; set; }

    public int? Gapdistance { get; set; }

    public string? Latupdated { get; set; }

    public string? Lngupdated { get; set; }

    public DateTime? AuthenOtpdate { get; set; }

    public bool IsDelete { get; set; }

    public string? SalesmanCode { get; set; }

    public DateTime? TimeSendOtp { get; set; }

    public string? HomePhone { get; set; }

    public string? UpdateType { get; set; }
}
