namespace Core.Models
{
    public class BaseRequest
    {
        public int SkipCount { get; set; } = 0;
        public int MaxResultCount { get; set; } = 10;
        public bool IsActiveFilter { get; set; } = true;
        public int? LevelFilter { get; set; }

        public BaseRequest()
        {
            SkipCount = 0;
            MaxResultCount = 10;
        }
        public BaseRequest(int pageNumber, int pageSize)
        {
            SkipCount = pageNumber;
            MaxResultCount = pageSize;
        }
    }
}
