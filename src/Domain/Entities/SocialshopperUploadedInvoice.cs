using System;
using System.Collections.Generic;

namespace Infra;

public partial class SocialshopperUploadedInvoice
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

    public string? ReferenceId { get; set; }

    public string? ImageLink { get; set; }

    public string? ImageThumbnailLink { get; set; }

    public string? Ocrdata { get; set; }

    public string? Status { get; set; }
}
