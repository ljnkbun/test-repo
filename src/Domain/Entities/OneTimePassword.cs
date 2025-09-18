using System;
using System.Collections.Generic;

namespace Infra;

public partial class OneTimePassword
{
    public int Id { get; set; }

    public int? TenantId { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public string? Otp { get; set; }

    public string? PhoneNumer { get; set; }

    public string? Type { get; set; }

    public DateTime UtcexpiredTime { get; set; }

    public DateTime? AuthenOtpdateTime { get; set; }

    public string? Smscontent { get; set; }
}
