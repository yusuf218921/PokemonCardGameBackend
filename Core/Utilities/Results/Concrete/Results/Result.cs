using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete.Results
{
    public class Result : IResult
    {
        public string Message { get; }
        public bool Success { get; }

        public Result(string message, bool success) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }
    }
}
