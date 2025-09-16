using Core.Models;

namespace Domain.Entities
{
    public class Permission : BaseEntity
    {
        public string PermissionCode { get; set; } = default!;

        public string PermissionName { get; set; } = default!;

        public int? PermissionParentId { get; set; }

        public int? PermissionRefId { get; set; }

        public string? Description { get; set; }
    }
}
