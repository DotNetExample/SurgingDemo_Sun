using Surging.Core.ProxyGenerator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.B.Service
{
    public class BService : ProxyServiceBase, IBService
    {
        public Task<string> SayHello(string name)
        {
            return Task.FromResult($"{name} say : hello");
        }
    }
}