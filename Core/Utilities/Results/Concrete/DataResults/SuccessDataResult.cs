using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete.DataResults
{
    internal class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(string message, T data) : base(data, message, true)
        {

        }

        public SuccessDataResult(T data) : base(data, true)
        {

        }

        public SuccessDataResult(string message) : base(default, message, true)
        {

        }

        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
