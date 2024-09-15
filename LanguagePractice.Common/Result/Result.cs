namespace LanguagePractice.Common.Result
{
    public class Result
    {
        public Result()
        {
            IsSuccess = true;
        }

        public Result(string error)
        {
            IsSuccess = false;
            ErrorMessage = error;
        }

        private bool IsSuccess { get; set; }
        private string? ErrorMessage { get; set; }

        public static Result Success()
        {
            return new Result();
        }

        public static Result Failure(string errorMessage)
        {
            return new Result(errorMessage);
        }
    }
}
