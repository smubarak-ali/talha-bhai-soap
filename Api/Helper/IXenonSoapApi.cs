using System;
using ServiceReference;

namespace Api.Helper
{
    public interface IXenonSoapApi
    {
        XenonServicePortTypeClient GetInstanceAsync();
    }
}
