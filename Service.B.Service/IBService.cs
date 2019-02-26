using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.B.Service
{
    [ServiceBundle("api/{Service}")]
    public interface IBService : IServiceKey
    {
        Task<string> SayHello(string name);
    }
}