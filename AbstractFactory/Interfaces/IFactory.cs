using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    internal interface IFactory
    {
        IRam GetRam();
        IProcessor GetProcessor();
        IMemory GetMemory();

        string GetDescription();
    }
}
