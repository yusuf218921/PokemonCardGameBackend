using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete.Results;

namespace Core.Utilities.Results.Concrete.DataResults
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; }

        public DataResult(T data, string message, bool success) : base(message, success)
        {
            Data = data;
        }

        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }
    }
}
