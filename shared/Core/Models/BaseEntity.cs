namespace Core.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public int UserCreatedId { get; set; }

        public int? UserModifiedId { get; set; }

        public int RecordStatus { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
