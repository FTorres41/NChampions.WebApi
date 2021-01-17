namespace NChampions.Domain.Responses
{
    public class ApiResponse
    {
        public dynamic Data { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }

        public ApiResponse(bool success, string message, object data = null)
        {
            Success = success;
            Message = message;
            Data = data;
        }
    }
}
