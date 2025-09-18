using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialretailerSaleOrder
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

    public Guid OrderGuid { get; set; }

    public string? MemberCode { get; set; }

    public DateTime AppointmentDate { get; set; }

    public int OrderType { get; set; }

    public string? Note { get; set; }

    public string? PhoneReceiver { get; set; }

    public string? NameReceiver { get; set; }

    public string? AddressReceiver { get; set; }

    public float SubTotal { get; set; }

    public float Discount { get; set; }

    public float Vat { get; set; }

    public float OrderTotal { get; set; }

    public string? Desc { get; set; }

    public int OrderStatus { get; set; }
}
