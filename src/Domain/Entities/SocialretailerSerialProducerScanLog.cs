using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerSerialProducerScanLog
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

    public string? Serial2 { get; set; }

    public string? ActivationCode { get; set; }

    public string? Message { get; set; }

    public string? Status { get; set; }

    public string? Manufacturer { get; set; }
}
