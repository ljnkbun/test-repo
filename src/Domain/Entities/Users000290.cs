using System;
using System.Collections.Generic;

namespace Infra;

public partial class Users000290
{
    public long Id { get; set; }

    public DateTime CreationTime { get; set; }

    public long? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public long? LastModifierUserId { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeleterUserId { get; set; }

    public DateTime? DeletionTime { get; set; }

    public string? AuthenticationSource { get; set; }

    public string UserName { get; set; } = null!;

    public int? TenantId { get; set; }

    public string EmailAddress { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? EmailConfirmationCode { get; set; }

    public string? PasswordResetCode { get; set; }

    public DateTime? LockoutEndDateUtc { get; set; }

    public int AccessFailedCount { get; set; }

    public bool IsLockoutEnabled { get; set; }

    public string? PhoneNumber { get; set; }

    public bool IsPhoneNumberConfirmed { get; set; }

    public string? SecurityStamp { get; set; }

    public bool IsTwoFactorEnabled { get; set; }

    public bool IsEmailConfirmed { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastLoginTime { get; set; }

    public string NormalizedUserName { get; set; } = null!;

    public string NormalizedEmailAddress { get; set; } = null!;

    public string? ConcurrencyStamp { get; set; }

    public Guid? ProfilePictureId { get; set; }

    public bool ShouldChangePasswordOnNextLogin { get; set; }

    public DateTime? SignInTokenExpireTimeUtc { get; set; }

    public string? SignInToken { get; set; }

    public string? GoogleAuthenticatorKey { get; set; }

    public int ManageUser { get; set; }

    public string? RegionCode { get; set; }

    public bool AuthorizationMicrosoft { get; set; }

    public string? DeviceId { get; set; }

    public string? DeviceId2 { get; set; }

    public string? UserType { get; set; }

    public string? AppType { get; set; }

    public bool Importing { get; set; }

    public int RowImport { get; set; }

    public int TotalRowImport { get; set; }

    public DateTime? LastDateImporting { get; set; }

    public string? LinkFileImport { get; set; }

    public int TotalRowError { get; set; }

    public int TotalRowSuccess { get; set; }
}
