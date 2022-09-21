using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementations
{
    internal class Snapdragon845Processor : IProcessor
    {
        public string GetProcessor()
        {
            return "Snapdragon845";
        }
    }

    internal class Snapdragon695Processor : IProcessor
    {
        public string GetProcessor()
        {
            return "Snapdragon695";
        }
    }
}
