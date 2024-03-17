using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mencoForWindows_winui3.Exceptions;

public class ApiException : Exception
{
    public int returnStatusCode { get; init; }

    public ApiException(int returnStatusCode,string? exMessage) : base($"{exMessage} ({returnStatusCode})")
    {
        this.returnStatusCode = returnStatusCode;
    }
}
