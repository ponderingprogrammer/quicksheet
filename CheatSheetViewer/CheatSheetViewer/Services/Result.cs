﻿namespace CheatSheetViewerApp.Services
{
    public class Result<T>
    {
        public bool IsSuccess => Code == ResultCode.Success;

        public ResultCode Code { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
        public T Data { get; set; }

        public static Result<T> Success(T data)
        {
            return new Result<T> {Code = ResultCode.Success, Data = data};
        }

        public static Result<T> Failure(string message)
        {
            return new Result<T> {Code = ResultCode.Failure, Message = message};
        }

        public static Result<T> Failure(string message, string source)
        {
            return new Result<T> {Code = ResultCode.Failure, Message = message, Source = source};
        }

        public enum ResultCode
        {
            Success,
            Failure,
        }
    }
}