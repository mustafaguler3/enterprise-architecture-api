using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public Result(string message,bool success):this(success)
        {
            Message = message;
            Success = success;
        }

        public Result(bool success)
        {
            Success = success;
        }
    }
}
