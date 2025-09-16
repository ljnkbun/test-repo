namespace Core.Models
{
    public class PagedResponse<T>
    {
        public PagedResponse()
        {
        }
        public PagedResponse(PagedResult<T> data, string message = null!)
        {
            Success = true;
            Result = data;
        }
        public PagedResponse(string message)
        {
            Success = false;
        }
        public bool Success { get; set; }
        public bool UnAuthorizedRequest { get; set; } = false;
        public string TargetUrl { get; set; } = default!;
        public List<Error> Error { get; set; }
        public PagedResult<T> Result { get; set; }
    }
    public class PagedResult<T>
    {
        public T Items { get; set; }
        public int TotalCount { get; set; }
    }
}
