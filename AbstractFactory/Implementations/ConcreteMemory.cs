using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementations
{
    internal class Memory128GB : IMemory
    {
        public int GetMemory()
        {
            return 128;
        }
    }

    internal class Memory256GB : IMemory
    {
        public int GetMemory()
        {
            return 256;
        }
    }

    internal class Memory512GB : IMemory
    {
        public int GetMemory()
        {
            return 512;
        }
    }

    internal class Memory1024GB : IMemory
    {
        public int GetMemory()
        {
            return 1024;
        }
    }
}
