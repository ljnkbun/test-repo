using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialshopperSubmittedSo
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

    public string? ChatId { get; set; }

    public string? MemberCode { get; set; }

    public string? Phone { get; set; }

    public DateTime? PostingDate { get; set; }

    public string? Socode { get; set; }

    public string? Status { get; set; }

    public decimal? TopupAmount { get; set; }
}
