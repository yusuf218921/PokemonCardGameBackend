using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Abstract
{
    public interface IResult
    {
        public String Message { get; }
        public bool Success { get; }
    }
}
