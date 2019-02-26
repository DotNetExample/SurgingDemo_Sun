using Surging.Core.ProxyGenerator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.A.Service
{
    public class AService : ProxyServiceBase, IAService
    {
        public Task<string> SayHelloA(string name)
        {
            return Task.FromResult($"{name} say : hello");
        }
    }
}