using System;
using System.ServiceModel;
using ServiceReference;

namespace Api.Helper
{
    public class XenonSoapApi : IXenonSoapApi
    {
        public readonly string _serviceUrl = "https://test.xenonfs.com/soap2";
        public readonly EndpointAddress _endpointAddress;
        public readonly BasicHttpBinding _basicHttpBinding;

        public XenonSoapApi()
        {
            _endpointAddress = new EndpointAddress(_serviceUrl);
            _basicHttpBinding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
            _basicHttpBinding.OpenTimeout = TimeSpan.MaxValue;
            _basicHttpBinding.CloseTimeout = TimeSpan.MaxValue;
            _basicHttpBinding.ReceiveTimeout = TimeSpan.MaxValue;
            _basicHttpBinding.SendTimeout = TimeSpan.MaxValue;
        }

        public XenonServicePortTypeClient GetInstanceAsync()
        {
            return new XenonServicePortTypeClient(_basicHttpBinding, _endpointAddress);
        }
    }
}
