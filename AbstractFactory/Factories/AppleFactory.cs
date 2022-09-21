using AbstractFactory.Implementations;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal class AppleFactory : IFactory
    {
        public IMemory GetMemory()
        {
            return new Memory128GB();
        }

        public IProcessor GetProcessor()
        {
            return new Snapdragon695Processor();
        }

        public IRam GetRam()
        {
            return new Ram16GB();
        }

        public string GetDescription()
        {
            return $"Processor: {GetProcessor().GetProcessor()}, Ram: {GetRam().GetRam()}, Memory: {GetMemory().GetMemory()}";
        }
    }
}
