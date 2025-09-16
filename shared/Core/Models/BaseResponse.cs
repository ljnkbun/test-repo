namespace Core.Models
{
    public class BaseResponse<T>
    {
        public BaseResponse()
        {
        }
        public BaseResponse(T data, string message = null!)
        {
            Success = true;
            Result = data;
        }
        public BaseResponse(string message)
        {
            Success = false;
        }
        public bool Success { get; set; }
        public bool UnAuthorizedRequest { get; set; } = false;
        public string TargetUrl { get; set; } = default!;
        public List<Error> Error { get; set; }
        public T Result { get; set; }
    }

    public class Error
    {
        public string? Code { get; set; }
        public string? Message { get; set; }
        public override string ToString() => $"{this.Code} - {this.Message}";
    }
}
