using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerSerialProducer2
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public string? Serial { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public string? Model { get; set; }

    public string? ActivationCode { get; set; }

    public string? Status { get; set; }

    public string? Reference { get; set; }

    public string? VehicleNumber { get; set; }

    public int? Plant { get; set; }

    public DateTime? ScanDate { get; set; }

    public string? Manufacturer { get; set; }

    public DateTime? ImportedDate { get; set; }

    public bool IsActive { get; set; }

    public int RuleId { get; set; }

    public string? MassOrder { get; set; }

    public string? Cont { get; set; }

    public string? MassOrderPo { get; set; }

    public DateTime MonthYear { get; set; }
}
