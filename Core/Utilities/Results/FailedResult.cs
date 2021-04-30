using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class FailedResult : Result
    {
        public FailedResult(string message) : base(success:false, message)
        {
        }
        public FailedResult() : base(success:false)
        {
        }

    }
}
