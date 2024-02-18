namespace Shop.Models
{
    public class BaseResponseModel<T>
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public T? Result { get; set; }


        public void SetSuccessResponse(T result)
        {
            IsSuccess = true;
            Result = result;
        }

        public void SetFailResponse(string message)
        {
            IsSuccess = false;
            Message = message;
        }
    }
}
