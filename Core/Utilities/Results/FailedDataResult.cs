using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class FailedDataResult<T> : DataResult<T>
    {
        public FailedDataResult(T data, string message) : base(data, success:false, message)
        {
        }

        public FailedDataResult(T data) : base(data, success:false)
        {
        }
        public FailedDataResult(string message) : base(default, success: false, message)
        {
        }
        public FailedDataResult() : base(default, success: false)
        {
        }
    }
}
