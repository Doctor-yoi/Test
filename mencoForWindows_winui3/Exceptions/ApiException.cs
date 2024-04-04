using System;

namespace mencoForWindows_winui3.Exceptions;

public class ApiException : Exception
{
    public int returnStatusCode { get; init; }

    public ApiException(int returnStatusCode, string? exMessage) : base($"{exMessage} ({returnStatusCode})")
    {
        this.returnStatusCode = returnStatusCode;
    }
}
