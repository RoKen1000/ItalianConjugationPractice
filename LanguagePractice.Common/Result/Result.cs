namespace LanguagePractice.Common.Result
{
    public class Result<T>
    {
        public Result(T data)
        {
            IsSuccess = true;
            Data = data;
        }

        public Result(string error)
        {
            IsSuccess = false;
            ErrorMessage = error;
        }

        public bool IsSuccess { get; set; }
        public string? ErrorMessage { get; set; }
        public T? Data { get; set; }

        public static Result<T> Success(T data)
        {
            return new Result<T>(data);
        }

        public static Result<T> Failure(string errorMessage)
        {
            return new Result<T>(errorMessage);
        }
    }
}
