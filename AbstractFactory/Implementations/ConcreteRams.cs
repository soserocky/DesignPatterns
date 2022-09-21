using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementations
{
    internal class Ram16GB : IRam
    {
        public int GetRam()
        {
            return 16;
        }
    }

    internal class Ram32GB : IRam
    {
        public int GetRam()
        {
            return 32;
        }
    }

    internal class Ram8GB : IRam
    {
        public int GetRam()
        {
            return 8;
        }
    }
}
