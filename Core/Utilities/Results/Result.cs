using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //getter readonly'dir. Readonly'ler set edilebilir.
        public Result(bool success)
        {
          
            Success = success;
        }
        public Result(bool success,string message):this(success) //bu classta tek parametreli olanı çalıştır demek.
        {
            Message = message;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
