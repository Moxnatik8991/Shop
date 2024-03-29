﻿namespace Shop.BackApp.Models
{
    public class BaseResponseModel<T>
    {
        public bool IsSuccess { get; set; }
        public string? ErrorMessage { get; set; }
        public T? Result { get; set; }


        public void SetSuccessResponse()
        {
            IsSuccess = true;
        }

        public void SetSuccessResponse(T result)
        {
            IsSuccess = true;
            Result = result;
        }

        public void SetFailResponse(string message)
        {
            IsSuccess = false;
            ErrorMessage = message;
        }
    }
}
