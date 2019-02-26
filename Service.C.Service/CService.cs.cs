using Surging.Core.ProxyGenerator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.A.Service
{
    public class CService: ProxyServiceBase, ICService
    {
        public Task<string> SayHello(string name)
        {
            return Task.FromResult($"{name} say : hello");
        }
    }
}